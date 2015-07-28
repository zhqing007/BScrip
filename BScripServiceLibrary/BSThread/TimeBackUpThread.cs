using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BScripServiceLibrary.BSThread {
    class Host_t {
        Host backuphost;
        long tspan;
        long monitor;
        public Host_t(Host h) {
            backuphost = h;
            tspan = h.tspan;
            monitor = h.monitor;
        }

        public bool IsTimeUp(long t) {
            if (tspan - t <= 0) {
                tspan = backuphost.tspan;
                return true;
            }
            tspan -= t;
            return false;
        }

        public bool IsMonitorTimeUp(long t) {
            if (monitor - t <= 0) {
                monitor = backuphost.monitor;
                return true;
            }
            monitor -= t;
            return false;
        }

        public Host GetHost() {
            return backuphost;
        }
    }

    class TimeBackUpThread {
        List<Host_t> bhosts;
        //static object lockobj = new object();

        public void BackUp() {
            TimeSpan onehour = new TimeSpan(1, 0, 0);
            while (true) {
                BSService.tbmu.WaitOne();
                List<Host> hosts = Host.GetTimeHosts();
                bhosts = new List<Host_t>();

                foreach (Host h in hosts) {
                    bhosts.Add(new Host_t(h));
                }

                foreach (Host_t timehost in bhosts) {
                    if (timehost.IsTimeUp(onehour.Ticks)) {
                        ConfThread.SaveHostConf(timehost.GetHost());
                    }
                }
                BSService.tbmu.ReleaseMutex();
                System.Threading.Thread.Sleep(onehour);
            }
        }

        //public void SetHost(Host item, long ticks) {
        //    BSService.tbmu.WaitOne();
        //    item.tspan = ticks;
        //    item.Update();
        //    int i;
        //    for(i = 0; i < bhosts.Count; ++i){
        //        if (bhosts[i].GetHost().hostname == item.hostname)
        //            break;
        //    }

        //    if (ticks == 0) {
        //        if (i == bhosts.Count)
        //            return;
        //        else
        //            bhosts.RemoveAt(i);
        //    }
        //    else{
        //        if (i == bhosts.Count)
        //            bhosts.Add(new Host_t(item));
        //        else {
        //            bhosts.RemoveAt(i);
        //            bhosts.Add(new Host_t(item));
        //        }
        //    }                    
        //    BSService.tbmu.ReleaseMutex();
        //}
    }
}
