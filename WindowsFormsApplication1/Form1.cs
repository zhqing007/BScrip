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
                chart1.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), yvalue);
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
            dt.Columns.Add("int1", typeof(string));
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });
            dt.Rows.Add(new string[] { "low", "15" });
            dt.Rows.Add(new string[] { "height", "75" });

            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) {
                if (this.dataGridView1.Rows[e.RowIndex].Cells[1].Value == DBNull.Value)
                    return;
                Random ra = new Random();
                Color bc;
                float wightpercent = ra.Next(101);
                Rectangle aaa = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, (int)((e.CellBounds.Width - 4) * wightpercent / 100),
                    e.CellBounds.Height - 4);

                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                if (wightpercent <= 50)
                    bc = Color.FromArgb(0, (int)(wightpercent / 50 * 255), (int)((1 - wightpercent / 50) * 255));
                else
                    bc = Color.FromArgb((int)((wightpercent / 50 - 1) * 255), (int)((2 - wightpercent / 50) * 255), 0);

                Brush brush = new SolidBrush(bc);//填充的颜色
                e.Graphics.FillRectangle(brush, aaa);
                e.Graphics.DrawString("sfasdfasd", e.CellStyle.Font, Brushes.Black,
                            e.CellBounds.Left + 5, e.CellBounds.Top + 5, StringFormat.GenericDefault);

                e.Handled = true;
            }
            //if (e.RowIndex >= 0 && e.ColumnIndex == 1) {
                
            //}
        }


        private void button3_Click(object sender, EventArgs e) {
            byte a = (byte)0x03;
            MessageBox.Show( a.ToString());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            MessageBox.Show("code:" + e.KeyCode.ToString() + System.Environment.NewLine
                + "value:" + e.KeyValue + System.Environment.NewLine
                + "data:" + e.KeyData);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.C) {
                MessageBox.Show("ctrl + c");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }



    }
}
