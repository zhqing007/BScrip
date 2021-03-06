﻿namespace BScrip.BSForms {
    partial class DBInfo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.upto = new System.Windows.Forms.Button();
            this.saveto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.winlogin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timespanUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timespanUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // upto
            // 
            this.upto.Location = new System.Drawing.Point(164, 241);
            this.upto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upto.Name = "upto";
            this.upto.Size = new System.Drawing.Size(66, 24);
            this.upto.TabIndex = 4;
            this.upto.Text = "关闭";
            this.upto.UseVisualStyleBackColor = true;
            this.upto.Click += new System.EventHandler(this.close_Click);
            // 
            // saveto
            // 
            this.saveto.Location = new System.Drawing.Point(58, 241);
            this.saveto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveto.Name = "saveto";
            this.saveto.Size = new System.Drawing.Size(66, 24);
            this.saveto.TabIndex = 3;
            this.saveto.Text = "保存";
            this.saveto.UseVisualStyleBackColor = true;
            this.saveto.Click += new System.EventHandler(this.saveto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "登录名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据源：";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(80, 77);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(173, 21);
            this.server.TabIndex = 9;
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(80, 178);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(173, 21);
            this.database.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(80, 151);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(173, 21);
            this.password.TabIndex = 11;
            // 
            // loginname
            // 
            this.loginname.Location = new System.Drawing.Point(80, 125);
            this.loginname.Name = "loginname";
            this.loginname.Size = new System.Drawing.Size(173, 21);
            this.loginname.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 56);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库类型";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(154, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Oracle";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SQL Server";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // winlogin
            // 
            this.winlogin.AutoSize = true;
            this.winlogin.Location = new System.Drawing.Point(80, 103);
            this.winlogin.Name = "winlogin";
            this.winlogin.Size = new System.Drawing.Size(90, 16);
            this.winlogin.TabIndex = 15;
            this.winlogin.Text = "Windows登录";
            this.winlogin.UseVisualStyleBackColor = true;
            this.winlogin.CheckedChanged += new System.EventHandler(this.winlogin_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "备份周期：";
            // 
            // timespanUpDown
            // 
            this.timespanUpDown.Location = new System.Drawing.Point(80, 205);
            this.timespanUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.timespanUpDown.Name = "timespanUpDown";
            this.timespanUpDown.Size = new System.Drawing.Size(76, 21);
            this.timespanUpDown.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "天";
            // 
            // DBInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timespanUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.winlogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.database);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upto);
            this.Controls.Add(this.saveto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timespanUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upto;
        private System.Windows.Forms.Button saveto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox loginname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox winlogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown timespanUpDown;
        private System.Windows.Forms.Label label6;
    }
}