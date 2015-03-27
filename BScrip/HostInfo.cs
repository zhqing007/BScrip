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
            if(Check())
                this.DialogResult = DialogResult.OK;
        }

        private bool Check() {
            if (NameBox.Text.Trim().Length == 0) {
                MessageBox.Show("没有填主机名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string regex = @"^(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(IPBox.Text.Trim(), regex)) {
                MessageBox.Show("IP格式不对！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (LoginNameBox.Text.Trim().Length == 0) {
                MessageBox.Show("没有填登录名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PWBox.Text.Length == 0) {
                MessageBox.Show("没有填密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void InfoCancle_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        //public String GetHostName() {
        //    return NameBox.Text.Trim();
        //}

        //public String GetIP() {
        //    return IPBox.Text.Trim();
        //}

        //public String GetLoginName() {
        //    return LoginNameBox.Text.Trim();
        //}

        //public String GetPW() {
        //    return PWBox.Text;
        //}

        //public String GetSPW() {
        //    return SPWBox.Text;
        //}

        //public Int16 GetLoginMode() {
        //    //0:telnet登录；1：ssh登录。
        //    if (telnetBox.Checked) return 0;
        //    return 1;
        //}

        public void SetHostName(string hname) {
            NameBox.Text = hname;
        }

        public void SetIP(string ip) {
            IPBox.Text = ip;
        }

        public void SetLoginName(string name) {
            LoginNameBox.Text = name;
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
            NameBox.ReadOnly = editable;
        }

        private void IPBox_TextChanged(object sender, EventArgs e) {
            string name = NameBox.Text.Trim();
            if (name.Length == 0 || name.Substring(0, name.Length - 1) == IPBox.Text)
                NameBox.Text = IPBox.Text;
        }

        public Host GetHost() {
            if (Check()) {
                Host h = new Host(NameBox.Text.Trim());
                h.ipaddress = IPBox.Text.Trim();
                h.loginmode = telnetBox.Checked ? 0 : 1;
                h.loginname = LoginNameBox.Text.Trim();
                h.password = PWBox.Text;
                h.superpw = SPWBox.Text;
                return h;
            }
            return null;
        }
    }
}
