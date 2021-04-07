using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна_робота_1
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap pixel, bmp;
        delegate void PixelFunc(int x, int y, Color c);

        public int x1, x2, y1, y2;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pixel = new Bitmap(1, 1);
            pictureBox1.Image = bmp;
            graphics = pictureBox1.CreateGraphics();
        }

        public void DefaultMethod()
        {
            x1 = int.Parse(first_x.Text); y1 = int.Parse(first_y.Text); x2 = int.Parse(second_x.Text); y2 = int.Parse(second_y.Text);
            
            Pen p = new Pen(Color.Black);
            graphics.DrawLine(p, new Point(x1, y1), new Point(x2, y2));
        }

        public void Bresenhem()
        {
            x1 = int.Parse(first_x.Text) + 50; y1 = int.Parse(first_y.Text) + 50; x2 = int.Parse(second_x.Text) + 50; y2 = int.Parse(second_y.Text) + 50;
            
            int widht = x2 - x1, hight = y2 - y1;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

            if (widht < 0)
            {
                dx1 = -1; 
                dx2 = -1;
            }
            else if (widht > 0)
            {
                dx1 = 1; 
                dx2 = 1;
            }

            if (hight < 0)
            {
                dy1 = -1;
            }
            else if (hight > 0)
            {
                dy1 = 1;
            }

            int longest = Math.Abs(widht);
            int shortest = Math.Abs(hight);

            if (!(longest > shortest))
            {
                longest = Math.Abs(hight);
                shortest = Math.Abs(widht);
                if (hight < 0)
                {
                    dy2 = -1;
                } 
                else if (hight > 0)
                {
                    dy2 = 1;

                }
                dx2 = 0;
            }

            int numerator = longest >> 1;

            for (int i = 0; i <= longest; i++)
            {
                SetPixel(x1, y1, Color.Green);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x1 += dx1;
                    y1 += dy1;
                }
                else
                {
                    x1 += dx2;
                    y1 += dy2;
                }
            }
        }
        private void CDA()
        {
            x1 = int.Parse(first_x.Text) + 100; y1 = int.Parse(first_y.Text) + 100; x2 = int.Parse(second_x.Text) + 100; y2 = int.Parse(second_y.Text) + 100;
            
            int dx = x2 - x1, dy = y2 - y1, steps, k, xf, yf;

            float xIncrement, yIncrement, x = x1, y = y1;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }

            else
            {
                steps = Math.Abs(dy);
            }

            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;
            PixelFunc func = new PixelFunc(SetPixel);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                xf = (int)x;
                y += yIncrement;
                yf = (int)y;
                try
                {
                    pictureBox1?.Invoke(func, xf, yf, Color.Blue);
                }
                catch (InvalidOperationException) { return; }
            }
        }

        private void SetPixel(int x, int y, Color c)
        {
            pixel.SetPixel(0, 0, c);
            graphics.DrawImageUnscaled(pixel, x, y);

            try
            {
                bmp.SetPixel(x, y, c);
            }
            catch (ArgumentOutOfRangeException) { return; }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(first_x.Text) == true || string.IsNullOrEmpty(first_y.Text) || string.IsNullOrEmpty(second_x.Text) || string.IsNullOrEmpty(second_y.Text))
            {
                MessageBox.Show("Ви не ввели координати!");
            }

            else
            {
                var stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                DefaultMethod();
                stopwatch1.Stop();
                default_algorithm.Text = stopwatch1.ElapsedMilliseconds.ToString();

                var stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                Bresenhem();
                stopwatch2.Stop();
                Bresenhems.Text = stopwatch2.ElapsedMilliseconds.ToString();

                var stopwatch3 = new Stopwatch();
                stopwatch3.Start();
                CDA();
                stopwatch3.Stop();
                CDAs.Text = stopwatch3.ElapsedMilliseconds.ToString();


            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            first_x.Text = null;
            first_y.Text = null;
            second_x.Text = null;
            second_y.Text = null;
            default_algorithm.Text = null;
            Bresenhems.Text = null;
            CDAs.Text = null;
        }
    }
}
