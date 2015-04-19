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
            double yvalue;
            Random ra = new Random();
            for (int i = 0; i < 50; ++i) {
                yvalue = ra.NextDouble() * 100;
                chart1.Series[0].Points.AddY(yvalue);
                if (chart1.Series[0].Points.Count > chart1.ChartAreas[0].AxisX.Maximum)
                    chart1.Series[0].Points.RemoveAt(0);
            }

            


        }

        private void Form1_Activated(object sender, EventArgs e) {
            //DrowC(Color.Green);
        }

        private void pictureBox1_VisibleChanged(object sender, EventArgs e) {
            //DrowC(Color.BurlyWood);
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            Graphics gra = this.pictureBox1.CreateGraphics();
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Color.Blue);//填充的颜色

            gra.FillEllipse(brush, 0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);//画填充椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("int1", typeof(int));
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) {
                if (this.dataGridView1.Rows[e.RowIndex].Cells[1].Value == DBNull.Value)
                    return;
                Rectangle aaa = new Rectangle(e.CellBounds.X + 9, e.CellBounds.Y + 9, e.CellBounds.Width - 20,
                    e.CellBounds.Height - 20);
                Brush brush = new SolidBrush(Color.LightBlue);//填充的颜色
                e.Graphics.FillEllipse(brush, aaa);
                e.Graphics.DrawString("sfasdfasd", e.CellStyle.Font, Brushes.Crimson,
                            e.CellBounds.Left + 20, e.CellBounds.Top + 5, StringFormat.GenericDefault);

                e.Handled = true;
            }
            //if (e.RowIndex >= 0 && e.ColumnIndex == 1) {
                
            //}
        }


        private void button3_Click(object sender, EventArgs e) {
            listView1.Items.Add("abc");
            listView1.Items.Add("dfg");
            listView1.Items.Add("aerebc");
        }



    }
}
