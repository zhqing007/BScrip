﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip {
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
            List<Host> hosts = Host.GetAllHosts();
            foreach (Host n in hosts) {
                AddHostToView(n);
            }
        }

        private void AddHostToView(Host h) {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = h;
            lvi.Text = h.hostname;
            lvi.SubItems.Add(h.ipaddress);
            if (h.loginmode == 0)
                lvi.SubItems.Add("T");
            else
                lvi.SubItems.Add("S");
            this.HostView.Items.Add(lvi);
        }

        private void selectAllHosts_Click(object sender, EventArgs e) {
            foreach (ListViewItem h in HostView.Items)
                h.Selected = true;
            HostView.Focus();
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

        private void HostView_DoubleClick(object sender, EventArgs e) {
            Host h = HostView.SelectedItems[0].Tag as Host;
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

        private void HostsForm_Resize(object sender, EventArgs e) {
            HostView.Height = Parent.Height - 70;
            selectAllHosts.Location =
                new Point(selectAllHosts.Location.X, Parent.Height - 65);
            add.Location =
                new Point(add.Location.X, Parent.Height - 65);
            del.Location =
                new Point(del.Location.X, Parent.Height - 65);
        }

        public List<Host> GetSelectHosts() {
            List<Host> selectedhosts = new List<Host>();
            foreach (ListViewItem hostn in HostView.SelectedItems)
                selectedhosts.Add(hostn.Tag as Host);
            return selectedhosts;
        }
    }
}
