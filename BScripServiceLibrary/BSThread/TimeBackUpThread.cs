using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BScripServiceLibrary.BSThread {
    class TimeBackUpThread {
        class Host_t {
            Host backuphost;
            long tspan;
            public Host_t(Host h){
                backuphost = h;
                tspan = h.tspan;
            }

            public bool IsTimeUp(long t) {
                if (tspan - t <= 0) {
                    tspan = backuphost.tspan;
                    return true;
                }
                tspan -= t;
                return false;
            }

            public Host GetHost() {
                return backuphost;
            }
        }

        List<Host_t> bhosts;
        static object lockobj = new object();

        public TimeBackUpThread() {
            List<Host> hosts = Host.GetTimeHosts();
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
                            ConfThread.SaveHostConf(timehost.GetHost());
                        }
                    }
                }
                System.Threading.Thread.Sleep(5 * 60 * 1000);
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
