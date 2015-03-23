using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;
using System.Threading;

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
        private Telnet tel_con;

        public RemoteLoginerTel(string _ip, string _name, string _pw, string _spw)
            : base(_ip, _name, _pw, _spw) {
                tel_con = new Telnet(_ip, 23, 30);
        }

        public override bool Connect() {
            tel_con.Connect();
            tel_con.WaitFor("Username:");
            tel_con.Send(name);
            tel_con.WaitFor("Password:");
            tel_con.Send(pw);
            tel_con.WaitFor(">");
            if (spw != null) {
                tel_con.Send("su");
                tel_con.WaitFor("Password:");
                tel_con.Send(spw);
                tel_con.WaitFor(">");
            }
            isConnected = true;
            return true;
        }

        public override void Send(string com) {
            tel_con.Send(com);
        }

        public override void WaitFor(string com) {
            tel_con.WaitFor(com);
        }

        public override string GetConfiguration() {
            if (!isConnected) return null;
            tel_con.Send("sys");
            tel_con.WaitFor("]");
            tel_con.Send("user-interface vty 0 4");
            tel_con.WaitFor("]");
            tel_con.Send("screen-length 0");
            tel_con.WaitFor("]");
            tel_con.Send("dis curr");
            tel_con.WaitFor("]");
            tel_con.Send("undo screen-length");
            tel_con.WaitFor("]");
            tel_con.Send("qu");
            tel_con.WaitFor("]");
            tel_con.Send("qu");
            tel_con.WaitFor(">");
            return tel_con.SessionLog;
        }

        public override void Close() {
            if (!isConnected) return ;
            tel_con.Send("qu");
            isConnected = false;
        }
    }

    public class RemoteLoginerSSH : RemoteLoginer {
        private SshStream ssh_con;

        public RemoteLoginerSSH(string _ip, string _name, string _pw, string _spw)
            : base(_ip, _name, _pw, _spw) { }

        public override bool Connect() {
            ssh_con = new SshStream(ip, name, pw);
            isConnected = true;
            return true;
        }

        public override void Send(string com) {
            ssh_con.Write(com);
        }

        public override void WaitFor(string com) {
            if(com == null || com.Length == 0) throw new NullReferenceException();

            byte[] back = new byte[1024];
            ssh_con.Read(back, 0, 1024);
            string backstr = Encoding.ASCII.GetString(back);
            string com_l = com.ToLower();
            while (!backstr.ToLower().Contains(com)) {
                Thread.Sleep(5);
                ssh_con.Read(back, 0, 1024);
                backstr = Encoding.ASCII.GetString(back);
                
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
            byte[] back = new byte[1024];
            ssh_con.Read(back, 0, 1024);
            StringBuilder logBuilder = new StringBuilder();
            string backstr =  Encoding.ASCII.GetString(back);
            while (!backstr.ToLower().Contains("]")) {
                logBuilder.Append(backstr);
                ssh_con.Read(back, 0, 1024);
                backstr = Encoding.ASCII.GetString(back);
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
