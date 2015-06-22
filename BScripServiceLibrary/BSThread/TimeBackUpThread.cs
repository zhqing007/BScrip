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

            public bool TimeUp(long t) {
                if (tspan - t <= 0) {
                    tspan = backuphost.tspan;
                    return true;
                }
                tspan -= t;
                return false;
            }
        }

        List<Host_t> hosts;

        public TimeBackUpThread() {
            List<Host> hosts = Host.GetTimeHosts();
            List<Host_t> bhosts = new List<Host_t>();

            foreach (Host h in hosts) {
                bhosts.Add(new Host_t(h));
            }
        }


    }
}
