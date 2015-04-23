using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip.BSForms {
    public partial class WelcomeForm : Form {
        public WelcomeForm() {
            InitializeComponent();
        }

        private void WelcomeForm_Shown(object sender, EventArgs e) {
            backgroundWorker1.RunWorkerAsync(1);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            System.Threading.Thread.Sleep((int)(e.Argument) * 1000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.Close();
        }
    }
}
