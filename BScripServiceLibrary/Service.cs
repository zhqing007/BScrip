using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace BScripServiceLibrary {
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BSService : IBSService {
        BSThread.TimeBackUpThread tbthreadobj;
        Thread tbthread;
        public BSService() {
            tbthreadobj = new BSThread.TimeBackUpThread();
            tbthread = new Thread(new ThreadStart(tbthreadobj.BackUp));
            tbthread.Start();
        }

        public string GetPath(){
            return System.IO.Directory.GetCurrentDirectory();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite) {
            return null;
        }

        public void SaveConf(string[] hostnames) {
            List<Host> hostlist = new List<Host>();
            foreach (string hostname in hostnames) {
                Host h = new Host(hostname);
                h.GetFromName();
                hostlist.Add(h);
            }
            BSThread.ConfThread confth = new BSThread.ConfThread(hostlist);
            Thread logThread = new Thread(new ThreadStart(confth.GetConfNoThread));
            logThread.Start();
        }

        public void SetSaveConfTime(string hostname, long span) {
            Host h = new Host(hostname);
            h.GetFromName();
            tbthreadobj.SetHost(h, span);
        }

        public Host[] GetHosts() {
            List<Host> hostlist = Host.GetAllHosts();
            return hostlist.ToArray();
        }

        public void AddHost(Host item) {
            item.Save();
        }

        public void UpdateHost(Host item) {
            item.Update();
        }

        
    }
}
