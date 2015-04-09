using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Graphics gra = this.CreateGraphics();
            //gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush bush = new SolidBrush(Color.Red);//填充的颜色
            gra.FillEllipse(bush, 0, 0, 100, 100);//画填充椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
       
        }
    }
}
