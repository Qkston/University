using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavd1
{
    public partial class Zavd1 : Form
    {
        public Zavd1()
        {
            InitializeComponent();
        }

        private void Zavd1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);

            Point[] points = new Point[4];
            points[0].X = 450; points[0].Y = 30;
            points[1].X = 480; points[1].Y = 170;
            points[2].X = 320; points[2].Y = 190;
            points[3].X = 290; points[3].Y = 50;
            for (int i = 0; i < 10; i++)
            {
                graph.DrawPolygon(pen, points);
            }
            pictureBox1.Image = bmp;

            Rectangle rect = new Rectangle(20, 150, 300, 300);
            float startAngle1 = 0.0F;
            float sweepAngle1 = 180.0F;
            Pen pen1 = new Pen(Color.BlueViolet);
            graph.DrawPie(pen1, rect, startAngle1, sweepAngle1);

            Rectangle rect1 = new Rectangle(320, 100, 400, 400);
            float startAngle2 = 0.0F;
            float sweepAngle2 = 45.0F;
            SolidBrush pen2 = new SolidBrush(Color.Red);
            graph.FillPie(pen2, rect1, startAngle2, sweepAngle2);

            pictureBox1.Image = bmp;
        }
    }
}
