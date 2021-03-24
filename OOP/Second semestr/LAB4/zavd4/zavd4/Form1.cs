using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavd4
{
    public partial class Form1 : Form
    {
        private int _x;
        private int _y;
        private int _x1;
        private int _y1;
        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;

            _x = 10;
            _y = 40;
            _x1 = 0;
            _y1 = 70;
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Silver, _x, _y, 200, 50);

            Rectangle rect = new Rectangle(_x + 60, _y, 70, 80);
            float startAngle1 = 0.0F;
            float sweepAngle1 = 90.0F;
            e.Graphics.FillPie(Brushes.Silver, rect, startAngle1, sweepAngle1);

            Rectangle rect1 = new Rectangle(_x + 60, _y - 30, 70, 80);
            float startAngle2 = 0.0F;
            float sweepAngle2 = -90.0F;
            e.Graphics.FillPie(Brushes.Silver, rect1, startAngle2, sweepAngle2);

            Rectangle rect2 = new Rectangle(_x + 1, _y - 10, 50, 80);
            float startAngle3 = 0.0F;
            float sweepAngle3 = -180.0F;
            e.Graphics.FillPie(Brushes.Silver, rect2, startAngle3, sweepAngle3);

            e.Graphics.FillEllipse(Brushes.Black, _x1 + 60, _y1 + 5, 40, 70);

            Point[] points = new Point[3];
            points[0].X = _x1 + 100; points[0].Y = _y1;
            points[1].X = _x1 + 60; points[1].Y = _y1;
            points[2].X = _x1 + 80; points[2].Y = _y1 + 25;

            e.Graphics.FillPolygon(Brushes.Black, points);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            _x += 2;
            _x1 += 2;
            _y1 += 5;
            Invalidate();
        }
    }
}
