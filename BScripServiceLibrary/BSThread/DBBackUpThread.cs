using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BScripServiceLibrary.BSDataBase;

namespace BScripServiceLibrary.BSThread {
    class DBBackUpThread {
        List<Host_t> bhosts;
        static object lockobj = new object();

        public DBBackUpThread(int uid) {
            List<Host> hosts = Host.GetAllHosts(uid, 2);
            bhosts = new List<Host_t>();

            foreach (Host h in hosts) {
                bhosts.Add(new Host_t(h));
            }
        }

        public void BackUp() {
            TimeSpan onehour = new TimeSpan(1, 0, 0);
            while (true) {
                lock (lockobj) {
                    foreach (Host_t timehost in bhosts) {
                        if (timehost.IsTimeUp(onehour.Ticks)) {
                            if (timehost.GetHost().loginmode == 0)
                                DBBackUp.SQLServerBackUp("");
                            else
                                DBBackUp.OracleBackUp(null, null, null);
                        }
                    }
                }
                System.Threading.Thread.Sleep(onehour);
            }
        }

        public void SetHost(Host item, long ticks) {
            lock (lockobj) {
                item.tspan = ticks;
                item.Update();
                int i;
                for(i = 0; i < bhosts.Count; ++i){
                    if (bhosts[i].GetHost().hostname == item.hostname)
                        break;
                }

                if (ticks == 0) {
                    if (i == bhosts.Count)
                        return;
                    else
                        bhosts.RemoveAt(i);
                }
                else{
                    if (i == bhosts.Count)
                        bhosts.Add(new Host_t(item));
                    else {
                        bhosts.RemoveAt(i);
                        bhosts.Add(new Host_t(item));
                    }
                }                    
            }
        }
    }
}
