using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        private void Add_Click(object sender, EventArgs e)
        {
            var label = new Label();
            label.Font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
            label.Text = $"Label {count+1}";
            label.Location = new Point(0, count++ * 30);
            this.Controls.Add(label);
        }

    }
}
