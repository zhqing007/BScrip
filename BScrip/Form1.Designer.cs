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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(93, 12);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 1;
            this.read.Text = "read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // readxml
            // 
            this.readxml.Location = new System.Drawing.Point(12, 63);
            this.readxml.Name = "readxml";
            this.readxml.Size = new System.Drawing.Size(95, 23);
            this.readxml.TabIndex = 3;
            this.readxml.Text = "ReadXml";
            this.readxml.UseVisualStyleBackColor = true;
            this.readxml.Click += new System.EventHandler(this.readxml_Click);
            // 
            // writeXml
            // 
            this.writeXml.Location = new System.Drawing.Point(12, 214);
            this.writeXml.Name = "writeXml";
            this.writeXml.Size = new System.Drawing.Size(95, 23);
            this.writeXml.TabIndex = 4;
            this.writeXml.Text = "WriteXml";
            this.writeXml.UseVisualStyleBackColor = true;
            this.writeXml.Click += new System.EventHandler(this.writeXml_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 25);
            this.textBox1.TabIndex = 5;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(157, 63);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 6;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 25);
            this.textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 364);
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
    }
}

