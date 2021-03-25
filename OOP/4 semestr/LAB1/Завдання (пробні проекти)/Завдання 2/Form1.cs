using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void sendButtom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(surName.Text) ||
                string.IsNullOrEmpty(yearOld.Text))
            {
                MessageBox.Show("Ви ввели не всі значення!");

            }
            else
            {
                MessageBox.Show("Ваша анкета успішно відправлена");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            Name.Text = "";
            surNameText.Text = "";
            surName.Text = "";
            yearOldText.Text = "";
            yearOld.Text = "";
        }
    }
}
