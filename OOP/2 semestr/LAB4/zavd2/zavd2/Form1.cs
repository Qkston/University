using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavd2
{
    public partial class Zavd_2 : Form
    {
        public Zavd_2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            SolidBrush pen = new SolidBrush(Color.Silver);
            SolidBrush pen1 = new SolidBrush(Color.Black);

            Point[] points = new Point[3];
            points[0].X = 320; points[0].Y = 100;
            points[1].X = 480; points[1].Y = 170;
            points[2].X = 320; points[2].Y = 170;

            Point[] points2 = new Point[3];
            points2[0].X = 320; points2[0].Y = 300;
            points2[1].X = 480; points2[1].Y = 170;
            points2[2].X = 320; points2[2].Y = 170;

            Point[] points3 = new Point[3];
            points3[0].X = 200; points3[0].Y = 220;
            points3[1].X = 140; points3[1].Y = 190;
            points3[2].X = 200; points3[2].Y = 190;

            Point[] points4 = new Point[3];
            points4[0].X = 200; points4[0].Y = 205;
            points4[1].X = 130; points4[1].Y = 230;
            points4[2].X = 200; points4[2].Y = 230;

            for (int i = 0; i < 10; i++)
            {
                graph.FillEllipse(pen, 180, 150, 400, 120);
                graph.FillEllipse(pen1, 520, 180, 20, 20);
                graph.FillPolygon(pen, points);
                graph.FillPolygon(pen, points2);
                graph.FillPolygon(pen, points3);
                graph.FillPolygon(pen, points4);
            }
            pictureBox1.Image = bmp;
        }
    }
}
