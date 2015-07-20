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

        private void close_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void saveto_Click(object sender, EventArgs e) {
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
            label4.Enabled = en;
            label4.Enabled = en;
            loginname.Enabled = en;
            password.Enabled = en;
        }

        private void winlogin_CheckedChanged(object sender, EventArgs e) {
            SetWinLogin(!((CheckBox)sender).Checked);
        }
    }
}
