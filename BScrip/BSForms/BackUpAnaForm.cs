using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip.BSForms {
    public partial class BackUpAnaForm : Form {
        List<Host> hosts;

        public BackUpAnaForm(List<Host> _hosts) {
            InitializeComponent();
            this.hosts = _hosts;
            anaStatusLabel.Text = "统计中......";
            statEnd.Value = DateTime.Now;
            statBegin.Value = DateTime.Now - TimeSpan.FromDays(30);
            backgroundWorker1.RunWorkerAsync();
        }

        private void close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            ListViewItem listItem;
            for(int i = 0; i < hosts.Count; ++i){
                listItem = new ListViewItem();
                listItem.Text = (i + 1).ToString();
                listItem.SubItems.Add(hosts[i].hostname);
                listItem.SubItems.Add(hosts[i].ipaddress);
                int num = DBhelper.GetDeviceBackUpCount(hosts[i].hostname
                    , statBegin.Value, statEnd.Value);
                listItem.SubItems.Add(num.ToString());
                backuplist.Items.Add(listItem);
            }

            anaStatusLabel.Text = "统计完毕！";
        }
    }
}
