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
            ListViewItem item = new ListViewItem(h.ipaddress);
            item.Tag = h;
            item.SubItems.Add(h.dbname);
            item.SubItems.Add(h.loginname);
            item.SubItems.Add((new TimeSpan(h.tspan)).TotalDays.ToString());
            item.SubItems.Add(h.loginmode == 0 ? "SQL Server" : "Oracle");
            deviceList.Items.Add(item);
        }

        private void UpdateHostToListView(Host h) {
            deviceList.SelectedItems[0].Text = h.ipaddress;
            deviceList.SelectedItems[0].Tag = h;
            deviceList.SelectedItems[0].SubItems[1].Text = h.dbname;
            deviceList.SelectedItems[0].SubItems[2].Text = h.loginname;
            deviceList.SelectedItems[0].SubItems[3].Text = (new TimeSpan(h.tspan)).TotalDays.ToString();
            deviceList.SelectedItems[0].SubItems[4].Text = h.loginmode == 0 ? "SQL Server" : "Oracle";
        }

        private void DBexport_Load(object sender, EventArgs e) {
            Host[] dbhosts = StaticFun.serverclient.GetDBHosts(StaticFun.loginID);
            
            foreach (Host h in dbhosts)
                AddHostToListView(h);
        }
    }
}
