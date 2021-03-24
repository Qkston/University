using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Індивідуальне_завдання
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
    }
}
