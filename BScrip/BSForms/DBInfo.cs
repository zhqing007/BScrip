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
            timespanUpDown.Value = (decimal)(new TimeSpan(dbhost.tspan)).TotalDays;

            if (dbhost.loginmode == 0)
                this.radioButton1.Checked = true;
            else
                this.radioButton2.Checked = true;

            if (dbhost.loginname.Length == 0)
                this.winlogin.Checked = true;
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

            if (winlogin.Checked)
                dbhost.loginname = dbhost.password = "";
            else {
                dbhost.loginname = loginname.Text;
                dbhost.password = password.Text;
            }
            
            dbhost.dbname = radioButton1.Checked ? database.Text : "";
            dbhost.hostname = dbhost.ipaddress;
            dbhost.type = 2; //数据库
            dbhost.loginmode = radioButton1.Checked ? 0 : 1;//0:sql; 1: oracle
            dbhost.tspan = (new TimeSpan((int)(timespanUpDown.Value), 0, 0, 0)).Ticks;


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
