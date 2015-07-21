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
    public partial class DBInfo : Form {
        public Host dbhost;
        public DBInfo() {
            InitializeComponent();
        }

        public DBInfo(Host host) {
            InitializeComponent();
            dbhost = host;
            server.Text = dbhost.ipaddress;
            loginname.Text = dbhost.loginname;
            password.Text = dbhost.password;
            database.Text = dbhost.hostname;
        }

        private void close_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void saveto_Click(object sender, EventArgs e) {
            if (server.Text.Trim().Length == 0) return;
            dbhost = new Host();
            dbhost.userid = StaticFun.loginID;
            dbhost.ipaddress = server.Text;
            dbhost.loginname = loginname.Text;
            dbhost.password = password.Text;
            dbhost.hostname = database.Text;
            dbhost.type = 2; //数据库
            dbhost.loginmode = radioButton1.Checked ? 0 : 1;//0:sql; 1: oracle
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            label4.Enabled = true;
            database.Enabled = true;
            winlogin.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            label4.Enabled = false;
            database.Enabled = false;
            winlogin.Enabled = false;
        }

        private void SetWinLogin(bool en) {
            label2.Enabled = en;
            label3.Enabled = en;
            loginname.Enabled = en;
            password.Enabled = en;
        }

        private void winlogin_CheckedChanged(object sender, EventArgs e) {
            SetWinLogin(!((CheckBox)sender).Checked);
        }
    }
}
