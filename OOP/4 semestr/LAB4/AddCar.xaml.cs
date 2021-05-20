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

            TypeValue[] option = (TypeValue[])Enum.GetValues(typeof(TypeValue));
            foreach (TypeValue soption in option)
            {
                Category_ComboBox.Items.Add(soption.ToString());
            }

            theCar = car;

            if (theCar != null && theCar.Model != null)
            {
                textBox1.Text = theCar.Company;
                textBox2.Text = theCar.Model;
                textBox3.Text = theCar.Year.ToString();
                textBox4.Text = theCar.Price.ToString();
                Category_ComboBox.SelectedIndex = Category_ComboBox.Items.IndexOf(car.Category.ToString());
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
                theCar.Category = (TypeValue)Enum.Parse(typeof(TypeValue), Category_ComboBox.SelectedItem.ToString());

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
