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
        protected string lastmessage;

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

        public virtual string ToUserInterface() {
            if (lastmessage == null) return null;
            char[] userif = {'>', ']', '#'};
            while (lastmessage.IndexOfAny(userif) < 0) {
                lastmessage = Read();
            }
            return lastmessage;
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
            lastmessage = tel_con.Login(username, password, timeout);
            return lastmessage;
        }

        public override void Close() {
            tel_con.Close();
        }

        public override void Send(string com) {
            tel_con.WriteLine(com);
        }

        public override string Read() {
            lastmessage = tel_con.Read();
            return lastmessage;
        }
    }

    public class SSH2Linker : Linker {
        private SshStream ssh_con = null;

        public SSH2Linker(string hostname, string username, string password)
            : base(hostname, username, password){}

        public override string Connect() {
            ssh_con = new SshStream(hostname, username, password);
            ssh_con.RemoveTerminalEmulationCharacters = true;
            lastmessage = ssh_con.ReadResponse();
            //string temp = null;
            //Thread.Sleep(10);
            //while (ssh_con.CanRead) {
            //    temp = ssh_con.ReadResponse();
            //    if (temp != null && temp.Length > 0)
            //        re = temp;
            //}
            return lastmessage;
        }

        public override void Close() {
            ssh_con.Close();
        }

        public override void Send(string com) {
            ssh_con.Write(com);
        }

        public override string Read() {
            lastmessage = ssh_con.ReadResponse();
            return lastmessage;
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
            lin.ToUserInterface();
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
            lin.Read();
            string r = lin.ToUserInterface();
            if (!r.TrimEnd().EndsWith(dev.LEVEL3_MARK_STR))
                throw new Exception("Failed WaitFor: " + dev.LEVEL3_MARK_STR);
            lin.Send(dev.USERVTY_STR);
            lin.WaitFor(dev.LEVEL3_MARK_STR);
            lin.Send(dev.SCRLEN0_STR);
            lin.WaitFor(dev.LEVEL3_MARK_STR);
            lin.Send(dev.CONFIGURATION_STR);
            string sessionLog = lin.Read().TrimEnd();

            while (!sessionLog.Contains(dev.CONFIGEND_MARK_STR)) {
                sessionLog += lin.Read().TrimEnd();
            }

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
