using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BScrip.BScripService;

namespace BScrip.BSForms {
    public partial class HostsForm : Form {
        public static HostsForm allhostsform;

        public HostsForm() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            HostView.Columns.Add("主机名", 100, HorizontalAlignment.Left);
            HostView.Columns.Add("IP地址", 120, HorizontalAlignment.Left);
            HostView.Columns.Add("M", 20, HorizontalAlignment.Left);
            LoadHostToListView();
        }

        private void LoadHostToListView() {
            HostView.Items.Clear();
            List<Host> hosts = null;// = Host.GetAllHosts();
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
                if (th.loginmode == 0)
                    downh.SubItems.Add("T");
                else
                    downh.SubItems.Add("S");
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
            //h.Save();
            AddHostToView(h);
        }

        private void del_Click(object sender, EventArgs e) {
            if (HostView.SelectedItems.Count == 0) return;
            if (MessageBox.Show("确认删除所选项么?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) return;
            foreach (ListViewItem hostn in HostView.SelectedItems) {
                Host h = hostn.Tag as Host;
                //h.Del();
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
                if (true /*sh.Update()*/) {
                    HostView.SelectedItems[0].SubItems[1].Text = sh.ipaddress;
                    if (sh.loginmode == 0)
                        HostView.SelectedItems[0].SubItems[2].Text = "T";
                    else
                        HostView.SelectedItems[0].SubItems[2].Text = "S";
                    HostView.SelectedItems[0].Tag = sh;
                }
            }
        }

        private void HostsForm_Resize(object sender, EventArgs e) {
            HostView.Height = add.Location.Y - 5;
            add.Location =
                new Point(selectAllHosts.Location.X * 2 / 3 + del.Location.X / 3
                    , add.Location.Y);
            showInfo.Location =
                new Point(add.Location.X + (del.Location.X - selectAllHosts.Location.X) / 3
                    , showInfo.Location.Y);
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

        private void setMenuVisible(bool visible) {
            addToBackUp.Visible = visible;
            deleteHost.Visible = visible;
            modifyHost.Visible = visible;
            hostDetails.Visible = visible;
            confviewer.Visible = visible;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e) {
            if (this.HostView.SelectedItems.Count == 0) {
                setMenuVisible(false);
                return;
            }
            setMenuVisible(true);
        }

        private void addToBackUp_Click(object sender, EventArgs e) {
            BSForms.BScripMDIParent.onlyOneMDI.AddHost();
        }

        private void confviewer_Click(object sender, EventArgs e) {
            BSForms.BScripMDIParent.onlyOneMDI.confviewer_Click(null, null);
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x00A1 && m.WParam.ToInt32() == 2) {
                m.Msg = 0x0201;
                m.LParam = IntPtr.Zero;
            }
            base.WndProc(ref m);
        }
    }
}
