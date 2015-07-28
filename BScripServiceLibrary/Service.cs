using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Data;
using BScripServiceLibrary.BSDevice;

namespace BScripServiceLibrary {
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BSService : IBSService {
        Thread tbthread, cmthread, dbbthread;
        public static Mutex tbmu = new Mutex(false);
        public static Mutex cmmu = new Mutex(false);
        public static Mutex dbmu = new Mutex(false);

        BSThread.TimeBackUpThread tbthreadobj;
        BSThread.CpuMemThread cmthreadobj;
        BSThread.DBBackUpThread dbbthreadobj;

        public BSService(bool begindbbackup, bool beginoracle = false) {
            tbthreadobj = new BSThread.TimeBackUpThread();
            tbthread = new Thread(new ThreadStart(tbthreadobj.BackUp));
            tbthread.Start();

            cmthreadobj = new BSThread.CpuMemThread();
            cmthread = new Thread(new ThreadStart(cmthreadobj.MonitorUp));
            cmthread.Start();

            if (begindbbackup == false) return;
            dbbthreadobj = new BSThread.DBBackUpThread(beginoracle);
            dbbthread = new Thread(new ThreadStart(dbbthreadobj.BackUp));
            dbbthread.Start();
        }

        public void StopThreads() {
            tbmu.WaitOne();
            tbthread.Abort();
            cmmu.WaitOne();
            cmthread.Abort();
            dbmu.WaitOne();
            if(dbbthread != null)
                dbbthread.Abort();
        }

        public string GetPath(){
            return System.IO.Directory.GetCurrentDirectory();
        }

        public void SaveConf(int userid, string[] hostnames) {
            List<Host> hostlist = new List<Host>();
            foreach (string hostname in hostnames) {
                Host h = new Host(userid, hostname);
                h.GetFromName();
                hostlist.Add(h);
            }
            BSThread.ConfThread confth = new BSThread.ConfThread(hostlist);
            Thread logThread = new Thread(new ThreadStart(confth.GetConfNoThread));
            logThread.Start();
        }

        //public void SetSaveConfTime(int userid, string hostname, long span) {
        //    Host h = new Host(userid, hostname);
        //    h.GetFromName();
        //    tbthreadobj.SetHost(h, span);
        //}

        public Host[] GetHosts(int userid) {
            List<Host> hostlist = Host.GetAllHosts(userid);
            return hostlist.ToArray();
        }

        //public void SetMonitorTime(int userid, string hostname, long span) {
        //    Host h = new Host(userid, hostname);
        //    h.GetFromName();
        //    cmthreadobj.SetHost(h, span);
        //}

        public void AddHost(Host item) {
            item.Save();
        }

        public void UpdateHost(Host item) {
            item.Update();
        }

        public int CheckUser(string name, string pw) {
            DataTable t_user =  DBhelper.ExecuteDataTable(
                "select id from user where loginname='" + name + "' and password='" + pw + "'", null);
            if (t_user.Rows.Count == 1) return Int32.Parse(t_user.Rows[0][0].ToString());
            return -1;
        }

        public Host[] GetBackUpHosts() {
            List<Host> hostlist = Host.GetTimeHosts();
            return hostlist.ToArray();
        }

        public Host[] GetDBHosts(int userid) {
            List<Host> hostlist = Host.GetAllHosts(userid, 2);
            return hostlist.ToArray();
        }

        public DateTime[] GetConSaveDate(string ip, DateTime begin, DateTime end) {
            DataTable dt = DBhelper.GetDeviceConfTime(ip, begin, end);
            DateTime[] ta = new DateTime[dt.Rows.Count];
            for(int i = 0; i < dt.Rows.Count; ++i){
                ta[i] = (DateTime)(dt.Rows[i][0]);
            }
            return ta;
        }

        public string GetConf(string ip, DateTime checkdate) {
            return DBhelper.GetDeviceConfiguration(ip, checkdate);
        }

        public ROccupy[] GetCpuMemOccupy(Host h, DateTime begintime, DateTime endtime) {
            DataTable occupy = DBhelper.GetCpuMemOccupy(h, begintime, endtime);            
            List<ROccupy> deol = new List<ROccupy>();
            if (occupy.Rows.Count == 0) return deol.ToArray();
            string slotname = occupy.Rows[0][1].ToString();
            int cpuo = 0;
            int memo = 0;
            int count = 0;
            ROccupy devo;
            foreach (DataRow row in occupy.Rows) {
                if (slotname != row["slotname"].ToString()) {
                    devo = new ROccupy();
                    devo.IP = h.ipaddress;
                    devo.SlotName = slotname;
                    devo.CpuOccupy = cpuo / count;
                    devo.MemOccupy = memo / count;
                    deol.Add(devo);
                    cpuo = memo = count = 0;
                    slotname = row[1].ToString();
                }
                ++count;
                cpuo += Int32.Parse(row["cpu"].ToString());
                memo += Int32.Parse(row["mem"].ToString());
            }
            devo = new ROccupy();
            devo.IP = h.ipaddress;
            devo.SlotName = slotname;
            devo.CpuOccupy = cpuo / count;
            devo.MemOccupy = memo / count;
            deol.Add(devo);

            return deol.ToArray();
        }

        public int[] GeConfCount(Host[] hl, DateTime begin, DateTime end) {
            int[] count = new int[hl.Length];
            for (int i = 0; i < hl.Length; ++i) {
                count[i] = DBhelper.GetDeviceBackUpCount(hl[i].ipaddress, begin, end);
            }
            return count;
        }

        public string GetBaseInfo(Host devicehost) {
            try {
                Device dev;
                DeviceBaseInfo dbi;
                if (devicehost.loginmode == 0) {
                    dev = Device.DeviceFactory(new TelnetLinker(devicehost.ipaddress, devicehost.loginname, devicehost.password)
                        , devicehost.superpw);
                    //Addstr(_server, "Telnet登录");
                }
                else {
                    dev = Device.DeviceFactory(new SSH2Linker(devicehost.ipaddress, devicehost.loginname, devicehost.password)
                        , devicehost.superpw);
                    //Addstr(_server, "SSH2登录");
                }

                dev.SuperPassWord = devicehost.superpw;
                dbi = dev.GetBaseInfo();
                return dbi.ToString();
            }
            catch (Exception exc) {
                return "操作出现异常：" + exc.ToString();
            }
        }

        public DataTable GetInterfaceInfo(Host devicehost) {
            try {
                Device dev;

                if (devicehost.loginmode == 0) {
                    dev = Device.DeviceFactory(new TelnetLinker(devicehost.ipaddress, devicehost.loginname, devicehost.password)
                        , devicehost.superpw);
                    //Addstr(_server, "Telnet登录");
                }
                else {
                    dev = Device.DeviceFactory(new SSH2Linker(devicehost.ipaddress, devicehost.loginname, devicehost.password)
                        , devicehost.superpw);
                    //Addstr(_server, "SSH2登录");
                }
                DataTable redt =  dev.GetInterfaceBrif();
                redt.TableName = "interfacetable";
                return redt;
            }
            catch (Exception exc) {
                return null;
            }
        }
    }
}
