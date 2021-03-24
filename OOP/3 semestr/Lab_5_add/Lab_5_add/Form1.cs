using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_add
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(90, 90, 160, this);
            DoubleBuffered = true;
            circle.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square square = new Square(0, 0, 160, this);
            DoubleBuffered = true;
            square.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rhomb romb = new Rhomb(50, 50, 160, 190, this);
            DoubleBuffered = true;
            romb.MoveRight();
        }
    }
}
