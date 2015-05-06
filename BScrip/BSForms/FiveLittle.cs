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

        private void AddHostToView(Host h) {
            List<Host> lh = new List<Host>();
            lh.Add(h);
            AddHostToView(lh);
        }

        private void selectAllHosts_Click(object sender, EventArgs e) {
            StaticFun.SelectAll_ListView(HostView);
        }

        private void add_Click(object sender, EventArgs e) {
            HostInfo host = new HostInfo();
            host.ShowDialog();
            if (host.DialogResult.Equals(DialogResult.Cancel)) return;
            Host h = host.GetHost();
            h.Save();
            AddHostToView(h);
        }

        private void del_Click(object sender, EventArgs e) {
            if (HostView.SelectedItems.Count == 0) return;
            if (MessageBox.Show("确认删除所选项么?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) return;
            foreach (ListViewItem hostn in HostView.SelectedItems) {
                Host h = hostn.Tag as Host;
                h.Del();
            }
            LoadHostToListView();
        }

        private void modifyHost_Click(object sender, EventArgs e) {
            Host h = HostView.SelectedItems[0].Tag as Host;
            HostInfo hostDia = new HostInfo();
            hostDia.SetNameBoxMode(true);

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
                    HostView.SelectedItems[0].Tag = sh;
                }
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
            foreach (object item in HostView.Items) {
                hostlist.Add((item as ListViewItem).Tag as Host);
            }
            
            FiveLittleLogMessageForm msgform = new FiveLittleLogMessageForm();
            FiveLittleConfThread confth = new FiveLittleConfThread(hostlist, msgform);
            Thread logThread = new Thread(new ThreadStart(confth.GetConfNoThread));
            logThread.Start();
            msgform.ShowDialog();
        }
    }

    public class FiveLittleConfThread {
        private List<Host> hosts;
        private FiveLittleLogMessageForm msgform;

        public FiveLittleConfThread(List<Host> hostl, FiveLittleLogMessageForm _msgform) {
            hosts = hostl;
            msgform = _msgform;
        }

        public void GetConfNoThread() {
            msgform.myEvent.WaitOne();
            Device dev = null;
            List<HostConfigStruct> hcList = new List<HostConfigStruct>();
            foreach (Host item in hosts) {
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

                    StringBuilder fileN = new StringBuilder(hc.device.hostname);
                    fileN.Append('_').Append(hc.device.ipaddress.Replace('.', '_'));
                    if (!Directory.Exists(fileN.ToString()))
                        Directory.CreateDirectory(fileN.ToString());
                    fileN = new StringBuilder(Path.GetFullPath(fileN.ToString()));
                    if (hc.filename == null)
                        hc.filename = DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
                    fileN.Append('\\').Append(hc.filename);

                    StreamWriter sw = File.CreateText(fileN.ToString());
                    msgform.AddLog(hc.device, "写入文件 " + fileN);
                    sw.Write(hc.config);
                    sw.Close();
                    msgform.AddLog(hc.device, "文件写入完成");
                }
                catch (Exception exc) {
                    msgform.AddLog(item, "导出配置出现异常：" + exc.StackTrace);
                }
                if (dev != null)
                    dev.Close();
            }

            msgform.ok.Enabled = true;
        }

        public class HostConfigStruct {
            public Host device;
            public string config;
            public string filename;
        }

    }
}
