using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BScrip {
    public partial class LogForm : Form {
        private AutoResetEvent logevent;

        public LogForm(AutoResetEvent loge) {
            InitializeComponent();
            logevent = loge;
            Control.CheckForIllegalCrossThreadCalls = false;
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
    }
}
