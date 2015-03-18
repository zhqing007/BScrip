using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip {
    public partial class HostInfo : Form {
        public HostInfo() {
            InitializeComponent();
        }

        private void InfoOK_Click(object sender, EventArgs e) {
            string regex = @"^(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(GetIP(), regex)) {
                MessageBox.Show("IP格式不对啊！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GetName().Length == 0) {
                MessageBox.Show("没有填登录名啊！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GetPW().Length == 0) {
                MessageBox.Show("没有填密码啊！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void InfoCancle_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        public String GetIP() {
            return IPBox.Text.Trim();
        }

        public String GetName() {
            return NameBox.Text.Trim();
        }

        public String GetPW() {
            return PWBox.Text;
        }

        public String GetSPW() {
            return SPWBox.Text;
        }
    }
}
