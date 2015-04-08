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

        public BackUpConfForm() {
            InitializeComponent();
            DownHosts.Columns.Add("主机名", 100, HorizontalAlignment.Left);
            DownHosts.Columns.Add("IP地址", 120, HorizontalAlignment.Left);
            DownHosts.Columns.Add("登录名", 120, HorizontalAlignment.Left);
            DownHosts.Columns.Add("登录方式", 80, HorizontalAlignment.Left);
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
                hostlist.Add((item as ListViewItem).Tag as Host);
            }

            AutoResetEvent logevent = new AutoResetEvent(false);
            LogForm logd = new LogForm(logevent);
            logd.ReDoButtons(false);
            GetConfThread confth = new GetConfThread(logd, logd.GetLogBox(), logevent, hostlist);
            Thread logThread = new Thread(new ThreadStart(confth.GetConfInThread));
            logThread.Start();
            logd.ShowDialog();
        }


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

        

        //private void SaveHost_(HostInfo info) {
            //xhelper.CreateOrGetXmlNodeByXPath("hosts", "host", info.GetIP());
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "Mode", info.GetLoginMode().ToString());
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "Name",
            //    EncodeAndDecode.EncodeBase64(info.GetLoginName()));
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "PW",
            //    EncodeAndDecode.EncodeBase64(info.GetPW()));
            //xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "SPW",
            //    EncodeAndDecode.EncodeBase64(info.GetSPW()));
            //xhelper.Reload();
        //}

        private void moveRightButton_Click(object sender, EventArgs e) {
            if(!StaticFun.AddHostListToListViewTag(HostsForm.allhostsform.GetSelectHosts(), DownHosts))
                return;
            Host th;
            foreach (ListViewItem downh in DownHosts.Items) {
                if (downh.Text.Length > 0) continue;
                th = downh.Tag as Host;
                downh.Text = th.hostname;
                downh.SubItems.Add(th.ipaddress);
                downh.SubItems.Add(th.loginname);
                if (th.loginmode == 0)
                    downh.SubItems.Add("Telnet");
                else
                    downh.SubItems.Add("SSH2");
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e) {
            if (DownHosts.SelectedItems.Count == 0) return;
            for (int p = DownHosts.SelectedItems.Count - 1; p >= 0; --p)
                DownHosts.Items.Remove(DownHosts.SelectedItems[p]);
        }

        private void selectAllHost_Click(object sender, EventArgs e) {
            StaticFun.SelectAll_ListView(DownHosts);
        }

        private void getConfB_remote_Click(object sender, EventArgs e) {
            FileTransfer tranHost = new FileTransfer();
            tranHost.ShowDialog();
            if (tranHost.DialogResult != DialogResult.OK) return;
            Host server = tranHost.GetServer();
            SshFileTransfer.PutFileSFTP(server, "/abcd/abc.txt");
        }

    }

    public class GetConfThread {
        private List<Host> hosts;
        private AutoResetEvent myResetEvent;
        private TextBox tbox;
        private LogForm logF;

        public GetConfThread(LogForm logfo, TextBox logbox, AutoResetEvent loge, List<Host> hostl) {
            logF = logfo;
            tbox = logbox;
            myResetEvent = loge;
            hosts = hostl;
        }

        public GetConfThread(TextBox logbox, List<Host> hostl) {
            tbox = logbox;
            hosts = hostl;
        }

        private void Addstr(Host item, string str) {
            StringBuilder strb = new StringBuilder(tbox.Text);
            strb.Append(DateTime.Now.GetDateTimeFormats('g')[0].ToString());
            if(item != null)
                strb.Append(item.hostname).Append(':');
            strb.Append(str).Append(System.Environment.NewLine);
            tbox.Text = strb.ToString();
        }

        public void GetConfNoThread() {
            RemoteLoginer loginer = null;
            foreach (Host item in hosts) {
                try {
                    if (item.loginmode == 0) {
                        loginer = new RemoteLoginerTel(item.ipaddress, item.loginname, item.password, item.superpw);
                        Addstr(item, "Telnet登录");
                    }
                    else {
                        loginer = new RemoteLoginerSSH(item.ipaddress, item.loginname, item.password, item.superpw);
                        Addstr(item, "SSH2登录");
                    }
                    if (loginer.Connect())
                        Addstr(item, "登录成功");
                    else {
                        Addstr(item, "登录失败");
                        continue;
                    }
                    string strConfiguration = loginer.GetConfiguration();
                    if (strConfiguration != null && strConfiguration.Trim().Length > 0)
                        Addstr(item, "导出配置成功");
                    else {
                        Addstr(item, "导出配置失败");
                        continue;
                    }
                    StringBuilder fileN = new StringBuilder(item.hostname);
                    fileN.Append('_').Append(item.ipaddress.Replace('.', '_'));
                    if (!Directory.Exists(fileN.ToString()))
                        Directory.CreateDirectory(fileN.ToString());
                    fileN = new StringBuilder(Path.GetFullPath(fileN.ToString()));
                    fileN.Append('\\').Append(DateTime.Now.ToString("yyyyMMddHHmm")).Append(".log");
                    StreamWriter sw = File.CreateText(fileN.ToString());
                    Addstr(item, "导出文件 " + fileN);
                    sw.Write(strConfiguration);
                    sw.Close();
                    loginer.Close();
                    Addstr(item, "文件写入完成" + System.Environment.NewLine + "******");
                }
                catch (Exception exc) {
                    Addstr(item, "导出配置出现异常：" + exc.StackTrace);
                }
            }
        }

        public void GetConfInThread() {
            myResetEvent.WaitOne();
            GetConfNoThread();
            logF.ReDoButtons(true);
        }
    }
 
}
