using System;
using System.Windows;

namespace LAB4
{
    public partial class AddCar : Window
    {
        public Car theCar;
        public AddCar(Car car)
        {
            InitializeComponent();

            theCar = car;
            if (theCar != null && theCar.Model != null && theCar.Model.Length != 0)
            {
                textBox1.Text = theCar.Company;
                textBox2.Text = theCar.Model;
                textBox3.Text = theCar.Year.ToString();
                textBox4.Text = theCar.Price.ToString();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                theCar.Company = textBox1.Text;
                theCar.Model = textBox2.Text;
                theCar.Year = Int32.Parse(textBox3.Text);
                theCar.Price = Int32.Parse(textBox4.Text);
                this.DialogResult = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Не вірно введені дані!");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
