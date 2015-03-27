using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Xml;
using System.IO;
using Tamir.SharpSsh;

namespace BScrip {
    public partial class Form1 : Form {
        //public Configuration cfa;
        //private XMLHelper xhelper;
        public Form1() {
            InitializeComponent();

            //xhelper = new XMLHelper();
            //if (!System.IO.File.Exists("HostList.xml")) {
            //    xhelper.CreateXmlDocument("HostList.xml", "hosts");
            //    return;
            //}

            //xhelper.XmlName = "HostList.xml";


            HostView.Columns.Add("主机名", 100, HorizontalAlignment.Left);
            HostView.Columns.Add("IP地址", 80, HorizontalAlignment.Left);
            HostView.Columns.Add("M", 20, HorizontalAlignment.Left);
            LoadHostToListBox();
            LoadHostToListView();

            //cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private void LoadHostToListView() {
            HostView.Items.Clear();
            List<Host> hosts = Host.GetAllHosts();
            foreach (Host n in hosts) {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = n.hostname;
                lvi.SubItems.Add(n.ipaddress);
                if (n.loginmode == 0)
                    lvi.SubItems.Add("T");
                else
                    lvi.SubItems.Add("S");
                this.HostView.Items.Add(lvi);
            }
        }

        private void LoadHostToListBox() {
            HostList.Items.Clear();
            List<Host> hosts = Host.GetAllHosts();
            foreach (Host n in hosts) {
                HostList.Items.Add(n.ipaddress);
            }
        }

        //private void LoadXmlToListBox() {
        //    HostList.Items.Clear();
        //    XmlNodeList hosts = xhelper.GetXmlNodeListByXpath("hosts//host");
        //    foreach (XmlNode n in hosts) {
        //        HostList.Items.Add(n.Attributes["key"].Value);
        //    }
        //}

        private void Execute_Click(object sender, EventArgs e) {
            try {
                RemoteLoginer loginer = null;
                foreach (object item in DownHosts.Items) {
                    Host h = new Host(item.ToString());
                    h.GetFromName();
                    if (h.loginmode == 0)
                        loginer = new RemoteLoginerTel(h.ipaddress, h.loginname, h.password, h.superpw);
                    else
                        loginer = new RemoteLoginerSSH(h.ipaddress, h.loginname, h.password, h.superpw);
                    loginer.Connect();
                    string strConfiguration = loginer.GetConfiguration();
                    StringBuilder fileN = new StringBuilder(item.ToString().Replace('.', '_'));
                    if(!Directory.Exists(fileN.ToString()))
                        Directory.CreateDirectory(fileN.ToString());
                    fileN.Append('\\').Append(DateTime.Now.ToString("yyyyMMddHHmm")).Append(".log") ;
                    StreamWriter sw = File.CreateText(fileN.ToString());
                    sw.Write(strConfiguration);
                    sw.Close();
                    loginer.Close();
                    MessageBox.Show("导出配置完成！");
                }
            }
            catch (Exception exc) {
                MessageBox.Show("连接失败:" + exc.ToString());
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

        private void add_Click(object sender, EventArgs e) {
            HostInfo host = new HostInfo();
            host.ShowDialog();
            if (host.DialogResult.Equals(DialogResult.Cancel)) return;
            Host h = host.GetHost();
            h.Save();
            HostList.Items.Add(h.ipaddress);
        }

        private void HostList_DoubleClick(object sender, EventArgs e) {
            Host h = new Host(HostList.SelectedItem.ToString());
            h.GetFromName();
            HostInfo hostDia = new HostInfo();
            hostDia.SetIPBoxMode(true);
            hostDia.SetIP(h.ipaddress); 
            hostDia.SetLoginName(h.loginname);
            hostDia.SetPW(h.password);
            hostDia.SetSPW(h.superpw);
            hostDia.SetLoginMode(h.loginmode);
            hostDia.ShowDialog();
            if (hostDia.DialogResult == DialogResult.OK)
                hostDia.GetHost().Update();
        }

        private void del_Click(object sender, EventArgs e) {
            if (HostList.SelectedItems.Count == 0) return;
            if (MessageBox.Show("确认删除所选项么?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) return;
            foreach (object hostn in HostList.SelectedItems) {
                Host h = new Host(hostn.ToString());
                h.Del();
            }

            LoadHostToListBox();
        }

        private void moveRightButton_Click(object sender, EventArgs e) {
            if (HostList.SelectedItems.Count == 0) return;
            bool befind = false;
            foreach (object hostn in HostList.SelectedItems) {
                foreach (object downip in DownHosts.Items)
                    if (downip.Equals(hostn)) { befind = true; break; };
                if (befind) continue;
                DownHosts.Items.Add(hostn);
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e) {
            if (DownHosts.SelectedItems.Count == 0) return;
            for (int p = DownHosts.SelectedItems.Count - 1; p >= 0; --p)
                DownHosts.Items.Remove(DownHosts.SelectedItems[p]);
        }

        private void SelectAllItems(ListBox li) {
            for (int i = 0; i < li.Items.Count; ++i)
                li.SelectedIndex = i;
        }

        private void selectAllHostList_Click(object sender, EventArgs e) {
            SelectAllItems(HostList);
        }

        private void selectAllHost_Click(object sender, EventArgs e) {
            SelectAllItems(DownHosts);
        }

        private void HostView_DoubleClick(object sender, EventArgs e) {
            Host h = new Host(HostView.SelectedItems[0].Text);
            h.GetFromName();
            HostInfo hostDia = new HostInfo();            
            hostDia.SetIPBoxMode(true);

            hostDia.SetHostName(h.hostname);
            hostDia.SetIP(h.ipaddress);
            hostDia.SetLoginName(h.loginname);
            hostDia.SetPW(h.password);
            hostDia.SetSPW(h.superpw);
            hostDia.SetLoginMode(h.loginmode);

            hostDia.ShowDialog();
            if (hostDia.DialogResult == DialogResult.OK) {
                Host sh = hostDia.GetHost();
                if (sh.Update()) {
                    HostView.SelectedItems[0].SubItems[1].Text = sh.ipaddress;
                    if (sh.loginmode == 0)
                        HostView.SelectedItems[0].SubItems[2].Text = "T";
                    else
                        HostView.SelectedItems[0].SubItems[2].Text = "S";
                }
            }
        }
    }
}
