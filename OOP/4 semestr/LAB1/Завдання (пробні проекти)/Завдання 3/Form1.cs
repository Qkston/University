using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                if (listBox1.SelectedIndex.Equals(0))
                {
                    graphics.Clear(BackColor);
                    graphics.FillRectangle(Brushes.Red, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }
                else if (listBox1.SelectedIndex.Equals(1))
                {
                    graphics.Clear(BackColor);
                    graphics.FillRectangle(Brushes.Yellow, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }
                else if (listBox1.SelectedIndex.Equals(2))
                {
                    graphics.Clear(BackColor);
                    graphics.FillRectangle(Brushes.Blue, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }
            }

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.Clear(BackColor);
                graphics.FillRectangle(Brushes.Green, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }

            pictureBox1.Image = bmp;
        }
    }
}
