using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openForm_Click(object sender, EventArgs e)
        {
            var thirdForm = new Form3();
            thirdForm.Show();
        }
    }
}
