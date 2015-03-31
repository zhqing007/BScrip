using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace BScrip {
    public partial class LogForm : Form {
        private AutoResetEvent logevent;

        public LogForm(AutoResetEvent loge) {
            InitializeComponent();
            logevent = loge;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void ReDoButtons(bool en) {
            LogFSaveB.Enabled = en;
            LogFCloseB.Enabled = en;
            LogFCopyB.Enabled = en;
        }

        private void LogForm_Load(object sender, EventArgs e) {
            logevent.Set();
        }

        public void AddLog(string txt) {
            logTextBox.Text += txt;
            logTextBox.Text += System.Environment.NewLine;
        }

        private void LogFCloseB_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LogFCopyB_Click(object sender, EventArgs e) {
            Clipboard.SetData(DataFormats.Text, logTextBox.Text);//复制内容到剪切板
            MessageBox.Show("日志已经复制到剪切板。", "复制", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogFSaveB_Click(object sender, EventArgs e) {
            SaveFileDialog fileD = new SaveFileDialog();
            fileD.Filter = "所有文件(*.*)|*.*";

            fileD.FilterIndex = 0;
            fileD.RestoreDirectory = true;
            if (fileD.ShowDialog() == DialogResult.OK) {
                StreamWriter sw = File.CreateText(fileD.FileName);
                sw.Write(logTextBox.Text);
                sw.Close();
            }
        }
    }
}
