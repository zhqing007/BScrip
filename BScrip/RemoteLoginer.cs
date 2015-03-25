using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;
using System.Threading;
using MinimalisticTelnet;

namespace BScrip {
    public abstract class RemoteLoginer {
        protected string ip;
        protected string name;
        protected string pw;
        protected string spw;
        protected bool isConnected;

        protected string Name {
            get { return name; }
        }        

        protected string Pw {
            get { return pw; }
        }

        protected string Spw {
            get { return spw; }
        }

        public string IP {
            get { return ip; }
        }

        public RemoteLoginer(string _ip, string _name, string _pw, string _spw) {
            ip = _ip;
            name = _name;
            pw = _pw;
            spw = _spw;
            isConnected = false;
        }

        public abstract bool Connect();
        public abstract void Close();
        public abstract void Send(string com);
        public abstract void WaitFor(string com);
        public abstract string GetConfiguration();
    }

    public class RemoteLoginerTel : RemoteLoginer {
        //private Telnet tel_con;
        private TelnetConnection tel_con;

        public RemoteLoginerTel(string _ip, string _name, string _pw, string _spw)
            : base(_ip, _name, _pw, _spw) {                
        }

        public override bool Connect() {
            tel_con = new TelnetConnection(ip, 23);
            string r = tel_con.Read();
            if (r.TrimEnd().EndsWith("Username:")) {
                tel_con.WriteLine(name);
                r = tel_con.Read();
                if (!r.TrimEnd().EndsWith("Password:")) return false;
                tel_con.WriteLine(pw);
                r = tel_con.Read();
            }

            if (r.TrimEnd().EndsWith(">")) {
                if (spw != null && spw.Length > 0) {
                    tel_con.WriteLine("su");
                    r = tel_con.Read();
                    if (r.TrimEnd().EndsWith("Password:")) {
                        tel_con.WriteLine(spw);
                        r = tel_con.Read();
                        if (!r.TrimEnd().EndsWith(">")) return false;
                    }
                }
                tel_con.WriteLine("sys");
                r = tel_con.Read();

            }
            if (!r.TrimEnd().EndsWith("]")) return false;
            isConnected = true;
            return true;
        }

        public override void Send(string com) {
            tel_con.WriteLine(com);
        }

        public override void WaitFor(string com) {
            if(!tel_con.Read().TrimEnd().EndsWith(com))
                throw new Exception("Failed WaitFor: " + com);
        }

        public override string GetConfiguration() {
            if (!isConnected) return null;
            tel_con.WriteLine("user-interface vty 0 4");
            WaitFor("]");
            tel_con.WriteLine("screen-length 0");
            WaitFor("]");
            tel_con.WriteLine("dis curr");
            string sessionLog = tel_con.Read().TrimEnd();
            if (!sessionLog.EndsWith("]"))
                throw new Exception("Failed get configuration");
            tel_con.WriteLine("undo screen-length");
            WaitFor("]");
            tel_con.WriteLine("qu");
            WaitFor("]");
            return sessionLog;
        }

        public override void Close() {
            if (!isConnected) return ;
            tel_con.WriteLine("qu");
            WaitFor(">");
            tel_con.WriteLine("qu");
            isConnected = false;
        }
    }

    public class RemoteLoginerSSH : RemoteLoginer {
        private SshStream ssh_con;

        public RemoteLoginerSSH(string _ip, string _name, string _pw, string _spw)
            : base(_ip, _name, _pw, _spw) { }

        public override bool Connect() {
            ssh_con = new SshStream(ip, name, pw);
            ssh_con.RemoveTerminalEmulationCharacters = true;
            ssh_con.ReadResponse();
            isConnected = true;
            return true;
        }

        public override void Send(string com) {
            ssh_con.Write(com);
        }

        public override void WaitFor(string com) {
            if(com == null || com.Length == 0) throw new NullReferenceException();
            try {
                //byte[] back = new byte[1024];
                //ssh_con.Read(back, 0, 1024);
                //string backstr = Encoding.ASCII.GetString(back);

                string backstr = ssh_con.ReadResponse();
                string com_l = com.ToLower();
                while (!backstr.ToLower().Contains(com)) {
                    Thread.Sleep(5);
                    backstr = ssh_con.ReadResponse();
                    //ssh_con.Read(back, 0, 1024);
                    //backstr = Encoding.ASCII.GetString(back);

                }
            }
            catch( Exception exc) {
                Console.WriteLine(exc.StackTrace);
                return;
            }
        }

        public override void Close() {
            ssh_con.Close();
            isConnected = false;
        }

        public override string GetConfiguration() {
            if (!isConnected) return null;
            Send("sys");
            WaitFor("]");
            Send("user-interface vty 0 4");
            WaitFor("]");
            Send("screen-length 0");
            WaitFor("]");
            Send("dis curr");
            StringBuilder logBuilder = new StringBuilder();
            string backstr = ssh_con.ReadResponse();
            while (!backstr.Contains("return")) {
                logBuilder.Append(backstr);
                backstr = ssh_con.ReadResponse();
            }
            logBuilder.Append(backstr);
            Send("undo screen-length");
            WaitFor("]");
            Send("qu");
            WaitFor("]");
            Send("qu");
            WaitFor(">");
            return logBuilder.ToString();
        }
    }
}
