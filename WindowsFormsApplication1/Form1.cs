using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        Color cor = Color.Red;

        public Form1() {
            InitializeComponent();
            
        }

        private void DrowC(Color c) {
            //Graphics gra = this.pictureBox1.CreateGraphics();
            ////gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Brush bush = new SolidBrush(c);//填充的颜色

            //gra.FillEllipse(bush, 0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);//画填充椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
        }

        private void button1_Click(object sender, EventArgs e) {
            cor = Color.Blue;
            pictureBox1.Invalidate();
        }

        private void Form1_Activated(object sender, EventArgs e) {
            //DrowC(Color.Green);
        }

        private void pictureBox1_VisibleChanged(object sender, EventArgs e) {
            //DrowC(Color.BurlyWood);
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e) {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            Graphics gra = e.Graphics;
            //gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush bush = new SolidBrush(cor);//填充的颜色
            gra.FillEllipse(bush, 0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);
        }


    }
}
