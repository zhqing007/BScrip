namespace BScrip
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.readxml = new System.Windows.Forms.Button();
            this.writeXml = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.XMLHosts = new System.Windows.Forms.ListBox();
            this.DownHosts = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(130, 251);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 1;
            this.read.Text = "read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // readxml
            // 
            this.readxml.Location = new System.Drawing.Point(49, 302);
            this.readxml.Name = "readxml";
            this.readxml.Size = new System.Drawing.Size(95, 23);
            this.readxml.TabIndex = 3;
            this.readxml.Text = "ReadXml";
            this.readxml.UseVisualStyleBackColor = true;
            this.readxml.Click += new System.EventHandler(this.readxml_Click);
            // 
            // writeXml
            // 
            this.writeXml.Location = new System.Drawing.Point(49, 453);
            this.writeXml.Name = "writeXml";
            this.writeXml.Size = new System.Drawing.Size(95, 23);
            this.writeXml.TabIndex = 4;
            this.writeXml.Text = "WriteXml";
            this.writeXml.UseVisualStyleBackColor = true;
            this.writeXml.Click += new System.EventHandler(this.writeXml_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 25);
            this.textBox1.TabIndex = 5;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(194, 302);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 6;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 386);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 25);
            this.textBox2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // XMLHosts
            // 
            this.XMLHosts.FormattingEnabled = true;
            this.XMLHosts.ItemHeight = 15;
            this.XMLHosts.Location = new System.Drawing.Point(49, 23);
            this.XMLHosts.Name = "XMLHosts";
            this.XMLHosts.Size = new System.Drawing.Size(252, 199);
            this.XMLHosts.TabIndex = 9;
            // 
            // DownHosts
            // 
            this.DownHosts.FormattingEnabled = true;
            this.DownHosts.ItemHeight = 15;
            this.DownHosts.Location = new System.Drawing.Point(446, 23);
            this.DownHosts.Name = "DownHosts";
            this.DownHosts.Size = new System.Drawing.Size(259, 199);
            this.DownHosts.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(335, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(335, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 524);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DownHosts);
            this.Controls.Add(this.XMLHosts);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.create);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.writeXml);
            this.Controls.Add(this.readxml);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.read);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button readxml;
        private System.Windows.Forms.Button writeXml;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox XMLHosts;
        private System.Windows.Forms.ListBox DownHosts;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

