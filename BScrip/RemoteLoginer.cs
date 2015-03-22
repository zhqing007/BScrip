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
        }

        public abstract bool Connect();
        public abstract void Send(string com);
        public abstract void WaitFor(string com);
    }

    public class RemoteLoginerTel : RemoteLoginer {
        private Telnet tel_con;

        public RemoteLoginerTel(string _ip, string _name, string _pw, string _spw)
            : base(_ip, _name, _pw, _spw) {
                tel_con = new Telnet(_ip, 23, 30);
        }

        public override bool Connect() {
            return tel_con.Connect();
        }

        public override void Send(string com) {
            tel_con.Send(com);
        }

        public override void WaitFor(string com) {
            tel_con.WaitFor(com);
        }
    }

    public class RemoteLoginerSSH : RemoteLoginer {
        private SshStream ssh_con;

        public RemoteLoginerSSH(string _ip, string _name, string _pw, string _spw)
            : base(_ip, _name, _pw, _spw) { }

        public override bool Connect() {
            ssh_con = new SshStream(ip, name, pw);
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
    }
}
