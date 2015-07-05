using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BScripServiceLibrary.BSDevice;

namespace BScripServiceLibrary.BSThread {
    class CpuMemThread {
        List<Host_t> mhosts;
        static object mlockobj = new object();

        public CpuMemThread() {
            List<Host> hosts = Host.GetCpuMemHosts();
            mhosts = new List<Host_t>();

            foreach (Host h in hosts) {
                mhosts.Add(new Host_t(h));
            }
        }

        private void savemonitordata(Host item) {
            try {
                Device dev = null;
                //DeviceBaseInfo dbi = null;
                List<ResourcesUtilization> cpurulist = null;
                List<ResourcesUtilization> memrulist = null;
                if (item.loginmode == 0) {
                    dev = Device.DeviceFactory(new TelnetLinker(item.ipaddress, item.loginname, item.password)
                        , item.superpw);
                    //Addstr(_server, "Telnet登录");
                }
                else {
                    dev = Device.DeviceFactory(new SSH2Linker(item.ipaddress, item.loginname, item.password)
                        , item.superpw);
                    //Addstr(_server, "SSH2登录");
                }

                dev.SuperPassWord = item.superpw;
                //dbi = dev.GetBaseInfo();
                cpurulist = dev.GetCpuUsage();
                memrulist = dev.GetMemUsage();
                DBhelper.SaveCpuMemOccupy(item, cpurulist, memrulist);
            }
            catch (Exception exc) {
                StaticFun.AddLog(item, "操作出现异常：" + exc.ToString());
            }
        }

        public void MonitorUp() {
            TimeSpan tenminute = new TimeSpan(0, 10, 0);
            while (true) {
                lock (mlockobj) {
                    foreach (Host_t timehost in mhosts) {
                        if (timehost.IsMonitorTimeUp(tenminute.Ticks)) {
                            savemonitordata(timehost.GetHost());
                        }
                    }
                }
                System.Threading.Thread.Sleep(tenminute);
            }
        }

        public void SetHost(Host item, long ticks) {
            lock (mlockobj) {
                item.monitor = ticks;
                item.Update();
                int i;
                for (i = 0; i < mhosts.Count; ++i) {
                    if (mhosts[i].GetHost().hostname == item.hostname)
                        break;
                }

                if (ticks == 0) {
                    if (i == mhosts.Count)
                        return;
                    else
                        mhosts.RemoveAt(i);
                }
                else {
                    if (i == mhosts.Count)
                        mhosts.Add(new Host_t(item));
                    else {
                        mhosts.RemoveAt(i);
                        mhosts.Add(new Host_t(item));
                    }
                }
            }
        }


    }
}
