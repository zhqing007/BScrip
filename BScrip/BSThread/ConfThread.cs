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
        private Host server;
        private List<string> filenames = new List<string>();

        public ConfThread(List<Host> hostl, Host _server = null) {
            server = _server;
            hosts = hostl;
        }

        //private void LogMessageForm.logForm.AddLog(Host item, string str) {
        //    StringBuilder strb = new StringBuilder();
        //    if (item == null)
        //        strb.Append(str).Append(System.Environment.NewLine);
        //    else {
        //        strb.Append(DateTime.Now.GetDateTimeFormats('g')[0].ToString());
        //        if (item != null)
        //            strb.Append('：').Append(item.hostname).Append("--");
        //        strb.Append(str).Append(System.Environment.NewLine);
        //    }
        //    tbox.AppendText(strb.ToString());
        //}

        public void GetConfNoThread() {
            Device dev = null;
            foreach (Host item in hosts) {
                try {
                    if (item.loginmode == 0) {
                        dev = Device.DeviceFactory(new TelnetLinker(item.ipaddress, item.loginname, item.password));
                        LogMessageForm.logForm.AddLog(item, "Telnet登录");
                    }
                    else {
                        dev = Device.DeviceFactory(new SSH2Linker(item.ipaddress, item.loginname, item.password));
                        LogMessageForm.logForm.AddLog(item, "SSH2登录");
                    }
                    dev.SuperPassWord = item.superpw;
                    string strConfiguration = dev.GetConfiguration();
                    if (strConfiguration != null && strConfiguration.Trim().Length > 0)
                        LogMessageForm.logForm.AddLog(item, "导出配置成功");
                    else {
                        LogMessageForm.logForm.AddLog(item, "导出配置失败");
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
                    LogMessageForm.logForm.AddLog(item, "导出文件 " + fileN);
                    sw.Write(strConfiguration);
                    sw.Close();
                    dev.Close();
                    LogMessageForm.logForm.AddLog(item, "文件写入完成");
                    LogMessageForm.logForm.AddLog(null, "******");
                }
                catch (Exception exc) {
                    LogMessageForm.logForm.AddLog(item, "导出配置出现异常：" + exc.StackTrace);
                }
            }
            if (server == null) return;
            try {
                SshFileTransfer.PutFileListSFTP(server, filenames);
                LogMessageForm.logForm.AddLog(server, "上传文件完成");
                foreach (string file in filenames) {
                    File.Delete(file.Substring(1));
                }
            }
            catch (Exception exc) {
                LogMessageForm.logForm.AddLog(server, "上传文件出现异常：" + exc.StackTrace);
            }
        }

        public void GetConfInThread() {
            //myResetEvent.WaitOne();
            GetConfNoThread();
            //logF.ReDoButtons(true);
        }
    }
}
