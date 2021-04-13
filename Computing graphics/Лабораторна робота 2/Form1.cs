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

namespace Лабораторна_робота_2
{
    public partial class Form1 : Form
    {
        Brush color;
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void BresenhemAlgorithm()
        {
            color = Brushes.Red;

            var graphics = Graphics.FromImage(pictureBox1.Image);
            
            var radius = Convert.ToDouble(textBox_Radius.Text);
            var X = Convert.ToInt32(textBox_X.Text);
            var Y = Convert.ToInt32(textBox_Y.Text);

            int x = 0, y = (int)radius, gap, delta = (int)(2 - 2 * radius);

            while (y >= 0)
            {
                graphics.FillRectangle(color, (X + x), (Y + y), 1, 1);
                graphics.FillRectangle(color, (X + x), (Y - y), 1, 1);
                graphics.FillRectangle(color, (X - x), (Y - y), 1, 1);
                graphics.FillRectangle(color, (X - x), (Y + y), 1, 1);

                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                if (delta > 0 && gap > 0)
                {
                    y--;
                    delta -= 2 * y + 1;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
            pictureBox1.Refresh();
        }

        private void MyAlgorithm()
        {
            color = Brushes.Green;

            var graphics = Graphics.FromImage(pictureBox1.Image);
            
            var radius = Convert.ToDouble(textBox_Radius.Text);
            var X = Convert.ToInt32(textBox_X.Text) * 2;
            var Y = Convert.ToInt32(textBox_Y.Text);

            for (int i = 0; i < 360; i++)
            {
                var x = X + Math.Round(radius * Math.Cos(i * Math.PI / 180));
                var y = Y - Math.Round(radius * Math.Sin(i * Math.PI / 180));
                graphics.FillRectangle(color, (int)x, (int)y, 1, 1);
            }
            pictureBox1.Refresh();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var stopwatch_for_Bresenhem = new Stopwatch();
            var stopwatch_for_My = new Stopwatch();

            try
            {
                stopwatch_for_Bresenhem.Start();
                BresenhemAlgorithm();
                stopwatch_for_Bresenhem.Stop();

                stopwatch_for_My.Start();
                MyAlgorithm();
                stopwatch_for_My.Stop();
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

                textBox_X.Text = null;
                textBox_Y.Text = null;
                textBox_Radius.Text = null;
                textBox_Bresenhem.Text = null;
                textBox_Bresenhem.Text = null;
            }

            textBox_Bresenhem.Text = stopwatch_for_Bresenhem.ElapsedMilliseconds.ToString();
            textBox_My.Text = stopwatch_for_My.ElapsedMilliseconds.ToString();
        }
    }
}