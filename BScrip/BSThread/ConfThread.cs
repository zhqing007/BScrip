using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using BScrip.BSForms;
using BScrip.BSDevice;

namespace BScrip.BSThread {
    public class ConfThread {
        private List<Host> hosts;
        private AutoResetEvent myResetEvent;
        private TextBox tbox;
        private LogForm logF;
        public Host server;
        private List<string> filenames = new List<string>();

        public ConfThread(LogForm logfo, TextBox logbox, AutoResetEvent loge, List<Host> hostl) {
            logF = logfo;
            tbox = logbox;
            myResetEvent = loge;
            hosts = hostl;
        }

        public ConfThread(TextBox logbox, List<Host> hostl) {
            tbox = logbox;
            hosts = hostl;
        }

        private void Addstr(Host item, string str) {
            StringBuilder strb = new StringBuilder();
            if (item == null)
                strb.Append(str).Append(System.Environment.NewLine);
            else {
                strb.Append(DateTime.Now.GetDateTimeFormats('g')[0].ToString());
                if (item != null)
                    strb.Append('：').Append(item.hostname).Append("--");
                strb.Append(str).Append(System.Environment.NewLine);
            }
            tbox.AppendText(strb.ToString());
        }

        public void GetConfNoThread() {
            Device dev = null;
            foreach (Host item in hosts) {
                try {
                    if (item.loginmode == 0) {
                        dev = Device.DeviceFactory(new TelnetLinker(item.ipaddress, item.loginname, item.password));
                        Addstr(item, "Telnet登录");
                    }
                    else {
                        dev = Device.DeviceFactory(new SSH2Linker(item.ipaddress, item.loginname, item.password));
                        Addstr(item, "SSH2登录");
                    }
                    dev.SuperPassWord = item.superpw;
                    string strConfiguration = dev.GetConfiguration();
                    if (strConfiguration != null && strConfiguration.Trim().Length > 0)
                        Addstr(item, "导出配置成功");
                    else {
                        Addstr(item, "导出配置失败");
                        continue;
                    }
                    StringBuilder fileN = new StringBuilder(item.hostname);
                    fileN.Append('_').Append(item.ipaddress.Replace('.', '_'));
                    StringBuilder filePath = new StringBuilder("/");
                    filePath.Append(fileN.ToString());
                    if (!Directory.Exists(fileN.ToString()))
                        Directory.CreateDirectory(fileN.ToString());
                    fileN = new StringBuilder(Path.GetFullPath(fileN.ToString()));
                    string filename = DateTime.Now.ToString("yyyyMMddHHmm") + ".log";
                    fileN.Append('\\').Append(filename);
                    filePath.Append('/').Append(filename);
                    filenames.Add(filePath.ToString());

                    StreamWriter sw = File.CreateText(fileN.ToString());
                    Addstr(item, "导出文件 " + fileN);
                    sw.Write(strConfiguration);
                    sw.Close();
                    dev.Close();
                    Addstr(item, "文件写入完成");
                    Addstr(null, "******");
                }
                catch (Exception exc) {
                    Addstr(item, "导出配置出现异常：" + exc.StackTrace);
                }
            }
            if (server == null) return;
            try {
                SshFileTransfer.PutFileListSFTP(server, filenames);
                Addstr(server, "上传文件完成");
                foreach (string file in filenames) {
                    File.Delete(file.Substring(1));
                }
            }
            catch (Exception exc) {
                Addstr(server, "上传文件出现异常：" + exc.StackTrace);
            }
        }

        public void GetConfInThread() {
            myResetEvent.WaitOne();
            GetConfNoThread();
            logF.ReDoButtons(true);
        }
    }
}
