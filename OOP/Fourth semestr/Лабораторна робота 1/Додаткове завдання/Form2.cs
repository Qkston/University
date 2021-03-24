using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Додаткове_завдання
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        protected void recordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameAndSurName.Text) || string.IsNullOrEmpty(phoneNumber.Text) || checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Не заповнені деякі поля форми!", "Помилка!");
            }
            else
            {
                MessageBox.Show(
                    $"{nameAndSurName}, ми успішно прийняли вашу інформацію та невдовзі передзвонимо вам на вказаний номер телефону: {phoneNumber}, для підтвердження.", "Успіх!");
                Close();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
