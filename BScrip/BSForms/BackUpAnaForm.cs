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
    public partial class BackUpAnaForm : Form {
        List<Host> hosts;
        DateTime bt, et;
        public BackUpAnaForm(List<Host> _hosts, DateTime begint, DateTime endt) {
            InitializeComponent();
            this.hosts = _hosts;
            anaStatusLabel.Text = "统计中......";
            et = endt;
            bt = begint;
            backgroundWorker1.RunWorkerAsync();
        }

        private void close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            ListViewItem listItem;
            int[] nums = StaticFun.serverclient.GeConfCount(hosts.ToArray(), bt, et);
            for (int i = 0; i < hosts.Count; ++i) {
                listItem = new ListViewItem();
                listItem.Text = (i + 1).ToString();
                listItem.SubItems.Add(hosts[i].hostname);
                listItem.SubItems.Add(hosts[i].ipaddress);
                listItem.SubItems.Add(nums[i].ToString());
                backuplist.Items.Add(listItem);
            }
            anaStatusLabel.Text = "统计完毕！";
        }

        private void export_Click(object sender, EventArgs e) {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "xls文件|*.xls";
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            DataTable dt = StaticFun.listViewToDataTable(backuplist);
            NPOIHelper.ExportDataTableToExcel(dt, fileDialog.FileName);
        }
    }
}
