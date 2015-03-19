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

        public Int16 GetLoginMode() {
            //0:telnet登录；1：ssh登录。
            if (telnetBox.Checked) return 0;
            return 1;
        }

        public void SetIP(string ip) {
            IPBox.Text = ip;
        }

        public void SetName(string name) {
            NameBox.Text = name;
        }

        public void SetPW(string PW) {
            PWBox.Text = PW;
        }

        public void SetSPW(string SPW) {
            SPWBox.Text = SPW;
        }

        public void SetLoginMode(int mo) {
            //0:telnet登录；1：ssh登录。
            if (mo == 0) telnetBox.Checked = true;
            else sshBox.Checked = true;
        }

        public void SetIPBoxMode(bool editable) {
            IPBox.ReadOnly = editable;
        }
    }
}
