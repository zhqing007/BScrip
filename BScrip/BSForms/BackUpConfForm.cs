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

namespace BScrip.BSForms {
    public partial class BackUpConfForm : BSForm {
        //public Configuration cfa;
        //private XMLHelper xhelper;

        public BackUpConfForm() {
            InitializeComponent();
            DownHosts.Columns.Add("主机名", 100, HorizontalAlignment.Left);
            DownHosts.Columns.Add("IP地址", 120, HorizontalAlignment.Left);
            DownHosts.Columns.Add("登录名", 120, HorizontalAlignment.Left);
            DownHosts.Columns.Add("登录方式", 80, HorizontalAlignment.Left);
            Host dfs = DBhelper.GetDefaultUpLoadServer();
            if (dfs != null) {
                remoser.Tag = dfs;
                remoser.Text = dfs.hostname;
            }
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
            if(isUpLoad.Checked)
                GetConfiguration(remoser.Tag as Host);
            else
                GetConfiguration(null);
        }

        private void GetConfiguration(Host _server) {
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
            BSThread.ConfThread confth = new BSThread.ConfThread(logd, logd.GetLogBox(), logevent, hostlist);
            confth.server = _server;
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

        public override void AddHost(Host h = null) {
            moveRightButton_Click(null, null);
        }

        private void moveLeftButton_Click(object sender, EventArgs e) {
            if (DownHosts.SelectedItems.Count == 0) return;
            for (int p = DownHosts.SelectedItems.Count - 1; p >= 0; --p)
                DownHosts.Items.Remove(DownHosts.SelectedItems[p]);
        }

        private void selectAllHost_Click(object sender, EventArgs e) {
            StaticFun.SelectAll_ListView(DownHosts);
        }

        private void isUpLoad_CheckedChanged(object sender, EventArgs e) {
            if (!(sender as CheckBox).Checked) {
                selserver.Enabled = false;
                return;
            }
            selserver.Enabled = true;
            if (remoser.Tag != null) return;
            selserver_Click(sender, e);
            if (remoser.Tag == null)
                isUpLoad.Checked = false;
        }

        private void selserver_Click(object sender, EventArgs e) {
            FileTransfer tranHost = new FileTransfer();
            tranHost.ShowDialog();
            if (tranHost.DialogResult != DialogResult.OK) return;
            Host ser = tranHost.GetServer();
            remoser.Tag = ser;
            remoser.Text = ser.hostname;
        }
    }

    public abstract class BSForm : Form {
        public abstract void AddHost(Host h = null);
    }
}
