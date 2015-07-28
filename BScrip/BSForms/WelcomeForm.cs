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
            //backgroundWorker1.RunWorkerAsync(1);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            System.Threading.Thread.Sleep((int)(e.Argument) * 1000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e) {
            StaticFun.loginID = StaticFun.serverclient.CheckUser(namebox.Text, pwbox.Text);
            //StaticFun.loginID = StaticFun.serverclient.CheckUser("zhqing", "111");
            if (StaticFun.loginID < 0)
                MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void close_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            Close();
        }
    }
}
