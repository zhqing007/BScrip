using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BScripServiceLibrary.BSDataBase;

namespace BScripServiceLibrary.BSThread {
    class DBBackUpThread {
        List<Host_t> bhosts;
        private bool beginoracle;

        public DBBackUpThread(bool beginoracle) {
            // TODO: Complete member initialization
            this.beginoracle = beginoracle;
        }

        public void BackUp() {
            TimeSpan onehour = new TimeSpan(1, 0, 0);
            while (true) {
                BSService.dbmu.WaitOne();
                List<Host> hosts = Host.GetTimeDataBase();
                bhosts = new List<Host_t>();

                foreach (Host h in hosts) {
                    bhosts.Add(new Host_t(h));
                }

                foreach (Host_t timehost in bhosts) {
                    if (!beginoracle && timehost.GetHost().loginmode == 1)
                        continue;
                    if (timehost.IsTimeUp(onehour.Ticks)) {
                        if (timehost.GetHost().loginmode == 0)
                            DBBackUp.SQLServerBackUp(timehost.GetHost().loginname
                                , timehost.GetHost().password
                                , timehost.GetHost().dbname
                                , timehost.GetHost().ipaddress);
                        else
                            DBBackUp.OracleBackUp(timehost.GetHost().loginname
                                , timehost.GetHost().password
                                , timehost.GetHost().ipaddress);
                    }
                }
                BSService.dbmu.ReleaseMutex();
                System.Threading.Thread.Sleep(onehour);
            }
        }
    }
}
