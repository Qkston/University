using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavd3
{
    public partial class Form1 : Form
    {
        double a, x, y, x1, y1;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            a = 0;
            x = y = 200;
            x1 = 600;
            y1 = 300;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Red), (int)x, (int)y, 20, 20);
            g.FillEllipse(new SolidBrush(Color.Red), (int)x1, (int)y1, 20, 20);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            x = x + 5 * Math.Cos(a);
            y = y + 5 * Math.Sin(a);
            x1 = x1 - 5 * Math.Cos(a);
            y1 = y1 - 5 * Math.Sin(a);
            a = a + 0.1;
            Refresh();
        }

    }
}
