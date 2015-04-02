using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Xml;
using System.IO;
using Tamir.SharpSsh;
using System.Threading;

namespace BScrip {
    public partial class BackUpConfForm : Form {
        //public Configuration cfa;
        //private XMLHelper xhelper;
        private System.Threading.Timer timersTimer;

        public BackUpConfForm() {
            InitializeComponent();

            //xhelper = new XMLHelper();
            //if (!System.IO.File.Exists("HostList.xml")) {
            //    xhelper.CreateXmlDocument("HostList.xml", "hosts");
            //    return;
            //}

            //xhelper.XmlName = "HostList.xml";
            

            //cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

       


        //private void LoadXmlToListBox() {
        //    HostList.Items.Clear();
        //    XmlNodeList hosts = xhelper.GetXmlNodeListByXpath("hosts//host");
        //    foreach (XmlNode n in hosts) {
        //        HostList.Items.Add(n.Attributes["key"].Value);
        //    }
        //}

        private void getConfB_Local_Click(object sender, EventArgs e) {
            if (DownHosts.Items.Count <= 0) {
                MessageBox.Show("没有要备份的主机！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            List<Host> hostlist = new List<Host>();
            foreach (object item in DownHosts.Items) {
                hostlist.Add(item as Host);
            }

            AutoResetEvent logevent = new AutoResetEvent(false);
            LogForm logd = new LogForm(logevent);
            logd.ReDoButtons(false);
            GetConfThread confth = new GetConfThread(logd, logevent, hostlist);
            Thread logThread = new Thread(new ThreadStart(confth.GetConf));
            logThread.Start();
            logd.ShowDialog();



            //Process p = new Process();

            //p.StartInfo.FileName = "wscript.exe";           //确定程序名
            //p.StartInfo.FileName = "telnet.exe";
            //p.StartInfo.Arguments = "-f D:\\WorkStation\\BScrip\\BScrip\\bin\\Debug\\abc.txt 10.116.176.254";    //确定程式命令行  
            //p.StartInfo.UseShellExecute = false;        //Shell的使用  
            //p.StartInfo.RedirectStandardInput = true;   //重定向输入  
            //p.StartInfo.RedirectStandardOutput = true; //重定向输出  
            //p.StartInfo.RedirectStandardError = true;   //重定向输出错误  
            //p.StartInfo.CreateNoWindow = true;          //设置置不显示窗口
            //p.Start();

            //p.StandardInput.WriteLine("mesadmin");       //也可以用这种方式输入入要行的命令  
            //p.StandardInput.WriteLine("mesWR172");
            //p.StandardInput.WriteLine("show ?");
            //p.StandardInput.WriteLine("                       ");
            //p.StandardInput.WriteLine("qu");        //要得加上Exit要不然下一行程式 
            //MessageBox.Show(p.StandardError.ReadToEnd());
            //MessageBox.Show(p.StandardOutput.ReadToEnd());

        }

        private void SaveHost_(HostInfo info) {
            //xhelper.CreateOrGetXmlNodeByXPath("hosts", "host", info.GetIP());
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "Mode", info.GetLoginMode().ToString());
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "Name",
            //    EncodeAndDecode.EncodeBase64(info.GetLoginName()));
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "PW",
            //    EncodeAndDecode.EncodeBase64(info.GetPW()));
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "SPW",
            //    EncodeAndDecode.EncodeBase64(info.GetSPW()));
            //xhelper.Reload();
        }





        private void moveRightButton_Click(object sender, EventArgs e) {
            List<Host> selectedhosts = HostsForm.allhostsform.GetSelectHosts();
            if (selectedhosts.Count == 0) return;
            bool befind = false;
            foreach (Host h in selectedhosts) {
                befind = false;
                foreach (object downh in DownHosts.Items)
                    if ((downh as Host).hostname.Equals(h.hostname)) { befind = true; break; };
                if (befind) continue;
                DownHosts.Items.Add(h);
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e) {
            if (DownHosts.SelectedItems.Count == 0) return;
            for (int p = DownHosts.SelectedItems.Count - 1; p >= 0; --p)
                DownHosts.Items.Remove(DownHosts.SelectedItems[p]);
        }

       

        private void SelectAllItems_Box(ListBox li) {
            for (int i = 0; i < li.Items.Count; ++i)
                li.SelectedIndex = i;
        }

        private void selectAllHost_Click(object sender, EventArgs e) {
            SelectAllItems_Box(DownHosts);
        }

        private void timerLocBu_Click(object sender, EventArgs e) {
            Test ta = new Test();
            ta.aa = "now:";
            timersTimer = new System.Threading.Timer(new TimerCallback(ta.fun), timerLogTBox, 5000, 1000);
            //timersTimer.
            //timersTimer.Elapsed += new System.Timers.ElapsedEventHandler(ta.fun);
            //timersTimer.Start();
        }

        private void timerRemBu_Click(object sender, EventArgs e) {
            timersTimer.Dispose();
        }
    }

    public class Test {
        public string aa;
        private static object locker = new object();
        private static int threadcount = 0;

        public void fun(object sender) {
            lock (locker) {
                if (threadcount > 0) return;
                ++threadcount;
            }
            (sender as TextBox).Text += 
                aa + DateTime.Now.ToLongTimeString() + System.Environment.NewLine;
            System.Threading.Thread.Sleep(3000);
            lock (locker) {
                --threadcount;
            }
        }
    }


    public class GetConfThread {
        private List<Host> hosts;
        private AutoResetEvent myResetEvent;
        private LogForm logF;

        public GetConfThread(LogForm logfo, AutoResetEvent loge, List<Host> hostl) {
            logF = logfo;
            myResetEvent = loge;
            hosts = hostl;
        }

        public void GetConf() {
            myResetEvent.WaitOne();
            try {
                RemoteLoginer loginer = null;
                foreach (Host item in hosts) {
                    if (item.loginmode == 0) {
                        loginer = new RemoteLoginerTel(item.ipaddress, item.loginname, item.password, item.superpw);
                        logF.AddLog(item.hostname + ":" + "Telnet登录");
                    }
                    else {
                        loginer = new RemoteLoginerSSH(item.ipaddress, item.loginname, item.password, item.superpw);
                        logF.AddLog(item.hostname + ":" + "SSH登录");
                    }
                    if(loginer.Connect())
                        logF.AddLog(item.hostname + ":" + "登录成功");
                    else{
                        logF.AddLog(item.hostname + ":" + "登录失败");
                        continue;
                    }
                    string strConfiguration = loginer.GetConfiguration();
                    if(strConfiguration != null && strConfiguration.Trim().Length > 0)
                        logF.AddLog(item.hostname + ":" + "导出配置成功");
                    else{
                        logF.AddLog(item.hostname + ":" + "导出配置失败");
                        continue;
                    }
                    StringBuilder fileN = new StringBuilder(item.hostname);
                    fileN.Append('_').Append(item.ipaddress.Replace('.', '_'));
                    if (!Directory.Exists(fileN.ToString()))
                        Directory.CreateDirectory(fileN.ToString());
                    fileN = new StringBuilder(Path.GetFullPath(fileN.ToString()));
                    fileN.Append('\\').Append(DateTime.Now.ToString("yyyyMMddHHmm")).Append(".log");
                    StreamWriter sw = File.CreateText(fileN.ToString());
                    logF.AddLog(item.hostname + ":" + "导出文件 " + fileN);
                    sw.Write(strConfiguration);
                    sw.Close();
                    loginer.Close();
                    logF.AddLog(item.hostname + ":" + "文件写入完成");
                    logF.AddLog("==================================");
                }
                logF.ReDoButtons(true);
            }
            catch (Exception exc) {
                logF.AddLog("导出配置出现异常：" + exc.StackTrace);
                logF.ReDoButtons(true);
            }
        }
    }
}
