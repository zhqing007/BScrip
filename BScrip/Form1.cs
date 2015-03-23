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
        private XMLHelper xhelper;
        public Form1() {
            InitializeComponent();
            xhelper = new XMLHelper();
            if (!System.IO.File.Exists("HostList.xml")) {
                xhelper.CreateXmlDocument("HostList.xml", "hosts");
                return;
            }

            xhelper.XmlName = "HostList.xml";
            LoadXmlToListBox();

            //cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private void LoadXmlToListBox() {
            XMLHosts.Items.Clear();
            XmlNodeList hosts = xhelper.GetXmlNodeListByXpath("hosts//host");
            foreach (XmlNode n in hosts) {
                XMLHosts.Items.Add(n.Attributes["key"].Value);
            }
        }

        //private void button1_Click(object sender, EventArgs e) {
        //    cfa.AppSettings.Settings.Add("key", "Name");
        //    cfa.AppSettings.Settings.Add("key1", "Name1");
        //    cfa.Save();
        //}

        //private void read_Click(object sender, EventArgs e) {
        //    String str = ConfigurationManager.AppSettings["Key"];
        //    MessageBox.Show(str);
        //    MessageBox.Show(cfa.AppSettings.Settings.Count.ToString());
        //}

        private void Execute_Click(object sender, EventArgs e) {
            try {
                RemoteLoginer loginer = null;
                //loginer = new RemoteLoginerTel("10.116.0.14", "petrochina", "Petrochina@123", null);
                loginer = new RemoteLoginerSSH("10.116.0.14", "petrochina", "Petrochina@123", null);
                loginer.Connect();
                StreamWriter sw = File.CreateText(@"log.txt");
                sw.Write(loginer.GetConfiguration());
                sw.Close();
                loginer.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception exc) {
                Console.WriteLine("连接失败:" + exc.ToString());
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

        //private void readxml_Click(object sender, EventArgs e) {
        //    XMLHelper x = new XMLHelper("HostList.xml");
        //    XmlNodeList tt = x.GetXmlNodeListByXpath("hosts//host");
        //    foreach (XmlNode n in tt) {
        //        MessageBox.Show(n.Attributes["key"].Value);
        //    }
        //}

        //private void create_Click(object sender, EventArgs e) {
        //    XMLHelper x = new XMLHelper();
        //    x.CreateXmlDocument("HostList.xml", "hosts");
        //}

        private void SaveHost(HostInfo info) {
            xhelper.CreateOrGetXmlNodeByXPath("hosts", "host", info.GetIP());
            xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "Mode", info.GetLoginMode().ToString());
            xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "Name",
                EncodeAndDecode.EncodeBase64(info.GetName()));
            xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "PW",
                EncodeAndDecode.EncodeBase64(info.GetPW()));
            xhelper.CreateOrUpdateXmlAttributeByXPath("hosts", "host", info.GetIP(), "SPW",
                EncodeAndDecode.EncodeBase64(info.GetSPW()));
        }

        private void add_Click(object sender, EventArgs e) {
            HostInfo host = new HostInfo();
            host.ShowDialog();
            if (host.DialogResult.Equals(DialogResult.Cancel)) return;
            SaveHost(host);
            XMLHosts.Items.Add(host.GetIP());
        }



        private void XMLHosts_DoubleClick(object sender, EventArgs e) {
            HostInfo hostDia = new HostInfo();
            hostDia.SetIPBoxMode(true);
            hostDia.SetIP(XMLHosts.SelectedItem.ToString());
            XmlNode node = xhelper.CreateOrGetXmlNodeByXPath("hosts", "host", XMLHosts.SelectedItem.ToString());
            hostDia.SetName(EncodeAndDecode.DecodeBase64(node.Attributes["Name"].Value));
            hostDia.SetPW(EncodeAndDecode.DecodeBase64(node.Attributes["PW"].Value));
            hostDia.SetSPW(EncodeAndDecode.DecodeBase64(node.Attributes["SPW"].Value));
            hostDia.SetLoginMode(Convert.ToInt16(node.Attributes["Mode"].Value));
            hostDia.ShowDialog();
            if (hostDia.DialogResult == DialogResult.OK)
                SaveHost(hostDia);
        }

        private void del_Click(object sender, EventArgs e) {
            if (XMLHosts.SelectedItems.Count == 0) return;
            if (MessageBox.Show("确认删除所选项么?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) return;
            foreach(object hostip in XMLHosts.SelectedItems)
                xhelper.RemoveXmlNodeByXPath("hosts", "host", hostip.ToString());
            LoadXmlToListBox();
        }

        private void moveRightButton_Click(object sender, EventArgs e) {
            if (XMLHosts.SelectedItems.Count == 0) return;
            foreach (object hostip in XMLHosts.SelectedItems)
                DownHosts.Items.Add(hostip);
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

        private void selectAllXml_Click(object sender, EventArgs e) {
            SelectAllItems(XMLHosts);
        }

        private void selectAllHost_Click(object sender, EventArgs e) {
            SelectAllItems(DownHosts);
        }
    }
}
