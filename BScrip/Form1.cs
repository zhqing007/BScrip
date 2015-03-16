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

namespace BScrip {
    public partial class Form1 : Form {
        public Configuration cfa;
        public Form1() {
            InitializeComponent();
            cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private void button1_Click(object sender, EventArgs e) {
            cfa.AppSettings.Settings.Add("key", "Name");
            cfa.AppSettings.Settings.Add("key1", "Name1");
            cfa.Save();
        }

        private void read_Click(object sender, EventArgs e) {
            String str = ConfigurationManager.AppSettings["Key"];
            MessageBox.Show(str);
            MessageBox.Show(cfa.AppSettings.Settings.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e) {
            Process p = new Process();

            p.StartInfo.FileName = "wscript.exe";           //确定程序名
            p.StartInfo.Arguments = "cmd";    //确定程式命令行  
            p.StartInfo.UseShellExecute = false;        //Shell的使用  
            p.StartInfo.RedirectStandardInput = true;   //重定向输入  
            p.StartInfo.RedirectStandardOutput = true; //重定向输出  
            p.StartInfo.RedirectStandardError = true;   //重定向输出错误  
            p.StartInfo.CreateNoWindow = true;          //设置置不显示示窗口¿  
            p.Start();

            p.StandardInput.WriteLine("telnet");       //也可以用这种方式输入入要行的命令  

            //p.StandardInput.WriteLine("exit");        //要得加上Exit要不然下一行程式 
            //MessageBox.Show(p.StandardError.ReadToEnd());
            MessageBox.Show(p.StandardOutput.ReadToEnd());

        }

        private void readxml_Click(object sender, EventArgs e) {
            XMLHelper x = new XMLHelper("net.xml");
            XmlNodeList tt = x.GetXmlNodeListByXpath("hosts//host");
            foreach (XmlNode n in tt) {
                MessageBox.Show(n.Attributes["key"].Value);
            }
        }

        private void create_Click(object sender, EventArgs e) {
            XMLHelper x = new XMLHelper();
            x.CreateXmlDocument("net.xml", "hosts");
        }

        private void writeXml_Click(object sender, EventArgs e) {
            XMLHelper x = new XMLHelper("net.xml");
            x.CreateOrGetXmlNodeByXPath("hosts", "host", textBox1.Text);
            x.CreateOrUpdateXmlAttributeByXPath("hosts", "host", textBox1.Text, "Name", textBox2.Text);
            MessageBox.Show("Done!");
        }
    }
}
