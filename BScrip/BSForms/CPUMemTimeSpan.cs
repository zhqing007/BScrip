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
    public partial class CPUMemTimeSpan : Form {
        public CPUMemTimeSpan() {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CPUMemTimeSpan_Shown(object sender, EventArgs e) {
            List<Host> allhost = new List<Host>(StaticFun.serverclient.GetHosts(StaticFun.loginID));
            foreach (Host host in allhost) {
                ListViewItem item = new ListViewItem(host.hostname);
                item.SubItems.Add(host.ipaddress);
                item.SubItems.Add((new TimeSpan(host.monitor)).TotalHours.ToString());
                item.Tag = host;
                hostlistview.Items.Add(item);
            }
        }

        private void hostlistview_SelectedIndexChanged(object sender, EventArgs e) {
            if (hostlistview.SelectedItems.Count == 0) return;
            Host host = (Host)(hostlistview.SelectedItems[0].Tag);
            ipbox.Text = host.ipaddress;
            hostime.Value = (decimal)((new TimeSpan(host.monitor)).TotalHours);
        }

        private void savebutton_Click(object sender, EventArgs e) {
            Host host = (Host)(hostlistview.SelectedItems[0].Tag);
            TimeSpan ts = new TimeSpan((int)(hostime.Value), 0, 0);
            host.monitor = ts.Ticks;
            StaticFun.serverclient.UpdateHost(host);
            //StaticFun.serverclient.SetMonitorTime(StaticFun.loginID, host.hostname, ts.Ticks);
            hostlistview.SelectedItems[0].Tag = host;
            hostlistview.SelectedItems[0].SubItems[2].Text = ts.TotalHours.ToString();
        }
    }
}
