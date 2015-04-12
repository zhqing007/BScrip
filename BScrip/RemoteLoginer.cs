using System;
using System.Collections.Generic;
using System.Text;
using Tamir.SharpSsh;
using System.Threading;
using MinimalisticTelnet;

namespace BScrip {
    public abstract class Linker {
        protected string hostname;
        protected string username;
        protected string password;

        public Linker(string ho, string user, string pw){
            hostname = ho;
            username = user;
            password = pw;
        }

        public abstract string Connect();
        public abstract void Close();
        public abstract void Send(string com);
        public abstract string Read();

        public virtual void WaitFor(string com){            
            if (com == null || com.Length == 0) throw new NullReferenceException();
            com = com.ToLower();
            for (int i = 0; i < 5; ++i) {
                if (Read().ToLower().Contains(com))
                    return;
                Thread.Sleep(50);
            }
            throw new Exception("Failed WaitFor: " + com);
        }
    }

    public class TelnetLinker : Linker {
        private int port;
        private int timeout;
        private TelnetConnection tel_con = null;
        

        public TelnetLinker(string hostname, string username, string password, int port = 23, int timeout = 100)
            : base(hostname, username,password){
            this.port = port;
            this.timeout = timeout;
        }

        public override string Connect() {
            tel_con = new TelnetConnection(hostname, port, timeout);
            return tel_con.Login(username, password, timeout);
        }

        public override void Close() {
            tel_con.Close();
        }

        public override void Send(string com) {
            tel_con.WriteLine(com);
        }

        public override string Read() {
            return tel_con.Read();
        }
    }

    public class SSH2Linker : Linker {
        private SshStream ssh_con = null;

        public SSH2Linker(string hostname, string username, string password)
            : base(hostname, username, password){}

        public override string Connect() {
            ssh_con = new SshStream(hostname, username, password);
            ssh_con.RemoveTerminalEmulationCharacters = true;
            Thread.Sleep(10);
            return ssh_con.ReadResponse();
        }

        public override void Close() {
            ssh_con.Close();
        }

        public override void Send(string com) {
            ssh_con.Write(com);
        }

        public override string Read() {
            return ssh_con.ReadResponse();
        }
    }

    public class RemoteConnecter {
        private Linker lin = null;
        private BSDevice.Device dev = null;
        public string SuperPassWord = null;
        public bool isSuper = false;

        public RemoteConnecter(Linker _lin) {
            SetLinker(_lin);
        }

        public void SetLinker(Linker _lin) {
            lin = _lin;
            dev = BSDevice.Device.DeviceFactory(lin.Connect());
        }

        private void SuperMe() {
            if (SuperPassWord == null || SuperPassWord.Length == 0) return;
            if (isSuper) return;

            lin.Send(dev.SUPERPW_MARK_STR);
            string r = lin.Read();
            if (!r.TrimEnd().EndsWith(dev.PASSWORD_MARK_STR))
                throw new Exception("Failed WaitFor: " + dev.PASSWORD_MARK_STR);
            lin.Send(SuperPassWord);
            r = lin.Read();
            if (!r.TrimEnd().EndsWith(dev.LEVEL1_MARK_STR)
                && !r.TrimEnd().EndsWith(dev.LEVEL3_MARK_STR))
                throw new Exception("Failed WaitFor: LEVEL_MARK_STR");
            isSuper = true;
        }

        public string GetConfiguration() {
            SuperMe();
            lin.Send(dev.SYS_MARK_STR);
            string r = lin.Read();
            if (!r.TrimEnd().EndsWith(dev.LEVEL3_MARK_STR))
                throw new Exception("Failed WaitFor: " + dev.LEVEL3_MARK_STR);
            lin.Send(dev.USERVTY_STR);
            lin.WaitFor(dev.LEVEL3_MARK_STR);
            lin.Send(dev.SCRLEN0_STR);
            lin.WaitFor(dev.LEVEL3_MARK_STR);
            lin.Send(dev.CONFIGURATION_STR);
            string sessionLog = lin.Read().TrimEnd();
            int i;
            for (i = 0; i < 5; ++i) {
                if (sessionLog.Contains(dev.CONFIGEND_MARK_STR)) break;
                sessionLog += lin.Read().TrimEnd();
            }
            if (i == 5) throw new Exception("Failed get configuration");

            lin.Send(dev.UNDOSCRLEN_STR);
            lin.WaitFor(dev.LEVEL3_MARK_STR);
            lin.Send(dev.QUIT_STR);
            lin.WaitFor(dev.LEVEL3_MARK_STR);
            return sessionLog;
        }

        public void Close() {
            lin.Close();
            lin = null;
        }
    }
}
