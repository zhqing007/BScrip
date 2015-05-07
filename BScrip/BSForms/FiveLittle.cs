using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BScrip.BSDevice;
using System.IO;

namespace BScrip.BSForms {
    public partial class FiveLittle : Form {
        public static FiveLittle allFiveLittle;

        public FiveLittle() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            HostView.Columns.Add("主机名", 100, HorizontalAlignment.Left);
            HostView.Columns.Add("IP地址", 120, HorizontalAlignment.Left);
            HostView.Columns.Add("登陆名", 120, HorizontalAlignment.Left);
            LoadHostToListView();
        }

        private void LoadHostToListView() {
            HostView.Items.Clear();
            List<Host> hosts = Host.GetAllHosts();
            AddHostToView(hosts);
        }

        private void AddHostToView(List<Host> lh) {
            StaticFun.AddHostListToListViewTag(lh, HostView);
            Host th;
            foreach (ListViewItem downh in HostView.Items) {
                if (downh.Text.Length > 0) continue;
                th = downh.Tag as Host;
                downh.Text = th.hostname;
                downh.SubItems.Add(th.ipaddress);
                downh.SubItems.Add(th.loginname);
            }
        }

        public List<Host> GetSelectHosts() {
            List<Host> selectedhosts = new List<Host>();
            foreach (ListViewItem hostn in HostView.SelectedItems)
                selectedhosts.Add(hostn.Tag as Host);
            return selectedhosts;
        }

        private void showInfo_Click(object sender, EventArgs e) {
            BSForms.BScripMDIParent.onlyOneMDI.ShowSwitchInfo();
        }


        private void addToBackUp_Click(object sender, EventArgs e) {
            BSForms.BScripMDIParent.onlyOneMDI.AddHost();
        }

        private void confviewer_Click(object sender, EventArgs e) {
            BSForms.BScripMDIParent.onlyOneMDI.confviewer_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e) {
            List<Host> hostlist = new List<Host>();
            FiveLittleLogMessageForm msgform = new FiveLittleLogMessageForm();
            FiveLittleConfThread thr = new FiveLittleConfThread(hostlist, msgform);
            FiveLittleConfThread.threadnum = 3;
            for (int i = 0; i < HostView.Items.Count; ++i) {
                hostlist.Add(HostView.Items[i].Tag as Host);
            }

            Thread logThread;
            for(int i = 0; i < FiveLittleConfThread.threadnum; ++i) {
                logThread = new Thread(new ThreadStart(thr.GetConfNoThread));
                logThread.Start();
            }
            msgform.ShowDialog();
        }
    }

    public class FiveLittleConfThread {
        private List<Host> hosts;
        private FiveLittleLogMessageForm msgform;
        public static int threadnum;
        private static object locklist = new object();

        public FiveLittleConfThread(List<Host> hostl, FiveLittleLogMessageForm _msgform) {
            hosts = hostl;
            msgform = _msgform;
        }

        public void GetConfNoThread() {
            msgform.myEvent.WaitOne();
            Device dev = null;
            List<HostConfigStruct> hcList = new List<HostConfigStruct>();
            Host item;

            while (true) {
                lock (locklist) {
                    if (hosts.Count > 0) {
                        item = hosts[0];
                        hosts.RemoveAt(0);
                    }
                    else{
                        if(--threadnum == 0)
                            msgform.ok.Enabled = true;
                        return;
                    }
                }

                try {
                    if (item.loginmode == 0)
                        dev = Device.DeviceFactory(new TelnetLinker(item.ipaddress, item.loginname, item.password)
                            , item.superpw);
                    else
                        dev = Device.DeviceFactory(new SSH2Linker(item.ipaddress, item.loginname, item.password)
                            , item.superpw);
                    msgform.AddLog(item, "已登录");

                    HostConfigStruct hc = new HostConfigStruct();
                    hc.device = item;
                    hc.config = dev.GetConfiguration();
                    if (hc.config != null && hc.config.Trim().Length > 0)
                        msgform.AddLog(item, "导出配置成功");
                    else {
                        msgform.AddLog(item, "导出配置失败");
                        continue;
                    }

                    StringBuilder fileN = new StringBuilder(DateTime.Now.ToString("yyyyMMdd"));

                    if (!Directory.Exists(fileN.ToString()))
                        Directory.CreateDirectory(fileN.ToString());
                    fileN = new StringBuilder(Path.GetFullPath(fileN.ToString()));
                    fileN.Append('\\').Append(hc.device.hostname).Append(".txt");

                    StreamWriter sw = File.CreateText(fileN.ToString());
                    msgform.AddLog(hc.device, "写入文件 " + fileN);
                    int strbegin = hc.config.IndexOf('[');
                    int strlength = hc.config.IndexOf("return") - strbegin + 6;
                    sw.Write(hc.config.Substring(strbegin, strlength));
                    sw.Close();
                    msgform.AddLog(hc.device, "文件写入完成");
                }
                catch (Exception exc) {
                    msgform.AddLog(item, "导出配置出现异常：" + exc.StackTrace);
                }
                if (dev != null)
                    dev.Close();
            }
        }

        public class HostConfigStruct {
            public Host device;
            public string config;
            public string filename;
        }

    }
}
