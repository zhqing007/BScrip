using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Data;

namespace BScripServiceLibrary {
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BSService : IBSService {
        BSThread.TimeBackUpThread tbthreadobj;
        Thread tbthread;
        BSThread.CpuMemThread cmthreadobj;
        Thread cmthread;

        public BSService() {
            //tbthreadobj = new BSThread.TimeBackUpThread();
            //tbthread = new Thread(new ThreadStart(tbthreadobj.BackUp));
            //tbthread.Start();

            //cmthreadobj = new BSThread.CpuMemThread();
            //cmthread = new Thread(new ThreadStart(cmthreadobj.MonitorUp));
            //cmthread.Start();
        }

        public string GetPath(){
            return System.IO.Directory.GetCurrentDirectory();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite) {
            return null;
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

        public void SetSaveConfTime(int userid, string hostname, long span) {
            Host h = new Host(userid, hostname);
            h.GetFromName();
            tbthreadobj.SetHost(h, span);
        }

        public Host[] GetHosts(int userid) {
            List<Host> hostlist = Host.GetAllHosts(userid);
            return hostlist.ToArray();
        }

        public void SetMonitorTime(int userid, string hostname, long span) {
            Host h = new Host(userid, hostname);
            h.GetFromName();
            cmthreadobj.SetHost(h, span);
        }

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

        public DateTime[] GetConSaveDate(string ip, DateTime begin, DateTime end) {
            DataTable dt = DBhelper.GetDeviceConfTime(ip, begin, end);
            DateTime[] ta = new DateTime[dt.Rows.Count];
            for(int i = 0; i < dt.Rows.Count; ++i){
                ta[i] = (DateTime)(dt.Rows[i][1]);
            }
            return ta;
        }

        public string GetConf(string ip, DateTime checkdate) {
            return DBhelper.GetDeviceConfiguration(ip, checkdate);
        }
    }
}
