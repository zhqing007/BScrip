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
    public partial class DBexport : BSForm {
        public DBexport() {
            InitializeComponent();
        }

        private void moveRightB_t_Click(object sender, EventArgs e) {
            if (!StaticFun.AddHostListToListViewTag(HostsForm.allhostsform.GetSelectHosts(), deviceList))
                return;
            Host th;
            foreach (ListViewItem downh in deviceList.Items) {
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

        private void moveLeftB_t_Click(object sender, EventArgs e) {
            if (deviceList.SelectedItems.Count == 0) return;
            for (int p = deviceList.SelectedItems.Count - 1; p >= 0; --p)
                deviceList.Items.Remove(deviceList.SelectedItems[p]);
        }

        public override void AddHost(Host h = null) {
            throw new NotImplementedException();
        }

        private void backupAna_Click(object sender, EventArgs e) {
            if (deviceList.Items.Count == 0) {
                MessageBox.Show("没有选择设备！"
                    , "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            List<Host> hosts = new List<Host>();
            foreach (ListViewItem h in deviceList.Items) {
                hosts.Add(h.Tag as Host);
            }

            //(new BackUpAnaForm(hosts)).ShowDialog();
        }

        private void monthAna_Click(object sender, EventArgs e) {

        }

        private void errorAna_Click(object sender, EventArgs e) {

        }

        private void add_Click(object sender, EventArgs e) {
            DBInfo didia = new DBInfo();
            didia.ShowDialog();
            if (didia.DialogResult != DialogResult.OK) return;
            StaticFun.serverclient.AddHost(didia.dbhost);
            AddHostToListView(didia.dbhost);
        }

        private void del_Click(object sender, EventArgs e) {
            if (deviceList.SelectedItems.Count == 0) return;
            Host tar = (Host)deviceList.SelectedItems[0].Tag;
            tar.tspan = 0;
            StaticFun.serverclient.UpdateHost(tar);
            UpdateHostToListView(tar);
        }

        private void deviceList_DoubleClick(object sender, EventArgs e) {
            if (deviceList.SelectedItems.Count == 0) return;
            Host tar = (Host)deviceList.SelectedItems[0].Tag;
            DBInfo didia = new DBInfo(tar);
            didia.ShowDialog();
            if (didia.DialogResult != DialogResult.OK) return;
            StaticFun.serverclient.UpdateHost(didia.dbhost);
            UpdateHostToListView(didia.dbhost);
        }

        private void AddHostToListView(Host h) {
            ListViewItem item = new ListViewItem(h.hostname);
            item.Tag = h;
            item.SubItems.Add(h.ipaddress);
            item.SubItems.Add(h.loginname);
            item.SubItems.Add((new TimeSpan(h.tspan)).TotalHours.ToString());
            item.SubItems.Add(h.loginmode == 0 ? "SQL Server" : "Oracle");
            deviceList.Items.Add(item);
        }

        private void UpdateHostToListView(Host h) {
            deviceList.SelectedItems[0].Text = h.hostname;
            deviceList.SelectedItems[0].Tag = h;
            deviceList.SelectedItems[0].SubItems[0].Text = h.ipaddress;
            deviceList.SelectedItems[0].SubItems[0].Text = h.loginname;
            deviceList.SelectedItems[0].SubItems[0].Text = (new TimeSpan(h.tspan)).TotalHours.ToString();
            deviceList.SelectedItems[0].SubItems[0].Text = h.loginmode == 0 ? "SQL Server" : "Oracle";
        }

        private void DBexport_Load(object sender, EventArgs e) {
            Host[] dbhosts = StaticFun.serverclient.GetDBHosts(StaticFun.loginID);
            
            foreach (Host h in dbhosts)
                AddHostToListView(h);
        }
    }
}
