using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip.BSForms {
    public partial class FiveLittleLogMessageForm : Form {
        private uint itemnum = 0;
        public System.Threading.ManualResetEvent myEvent = new System.Threading.ManualResetEvent(false);
        private static object locker = new object();

        public FiveLittleLogMessageForm() {
            InitializeComponent();
        }

        public void AddLog(Host item, string str) {
            lock (locker) {
                ListViewItem logitem = new ListViewItem();
                logitem.Text = (++itemnum).ToString();
                logitem.SubItems.Add(DateTime.Now.GetDateTimeFormats('g')[0].ToString());
                logitem.SubItems.Add(item.ipaddress);
                logitem.SubItems.Add(str);
                if (loglist.Items.Count > 200) loglist.Items.RemoveAt(200);
                this.loglist.Items.Insert(0, logitem);
            }
        }

        public string GetLog() {
            StringBuilder logb = new StringBuilder();
            foreach (ListViewItem item in loglist.Items) {
                logb.Append(item.Text).Append('\t')
                    .Append(item.SubItems[1].Text).Append('\t')
                    .Append(item.SubItems[2].Text).Append('\t')
                    .Append(item.SubItems[3].Text).Append(System.Environment.NewLine);
            }
            return logb.ToString();
        }

        private void copy_Click(object sender, EventArgs e) {
            Clipboard.SetText(GetLog());
        }

        private void save_Click(object sender, EventArgs e) {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            fileDialog.FileName = "操作日志" + DateTime.Now.ToString("yyyyMMddHHmm");
            if (fileDialog.ShowDialog() != DialogResult.OK) return;

            System.IO.StreamWriter sw = System.IO.File.CreateText(fileDialog.FileName);
            sw.Write(GetLog());
            sw.Close();
        }

        private void clear_Click(object sender, EventArgs e) {
            loglist.Items.Clear();
            this.ContextMenuStrip = null;
            itemnum = 0;
        }

        private void ok_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FiveLittleLogMessageForm_Shown(object sender, EventArgs e) {
            this.myEvent.Set();
        }
    }
}
