using System.Collections.Generic;
using System.Windows;

namespace LAB4
{
    public partial class CarsInRental : Window
    {
        public CarsInRental()
        {
            InitializeComponent();
        }

        List<Vehicle> allVehicles = new List<Vehicle>();

        private void BackButton_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindowForm = new MainWindow();
            mainWindowForm.Show();
            this.Close();
        }

        private void AddNewCarButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle newVehicle = new Vehicle();
            AddCarInRental addCarWindow = new AddCarInRental(newVehicle);
            if (addCarWindow.ShowDialog() == true)
            {
                listBox1.Items.Add(newVehicle.ToString());
                allVehicles.Add(newVehicle);
            }
            else
            {
                MessageBox.Show("Ваші дані не збережені");
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= allVehicles.Count)
            {
                MessageBox.Show("Ви не обрали жодного автомобіля");
                return;
            }
            AddCarInRental addCarInRentalWindow = new AddCarInRental(allVehicles[listBox1.SelectedIndex]);
            if (addCarInRentalWindow.ShowDialog() == true)
            {
                listBox1.Items[idx] = allVehicles[listBox1.SelectedIndex].ToString();
            }
            else
            {
                MessageBox.Show("Ваші дані не збережені");
            }
        }

        private void DeleteCar_Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= allVehicles.Count)
            {
                MessageBox.Show("Ви не обрали жодного автомобіля");
                return;
            }
            allVehicles.RemoveAt(selectedIndex);
            listBox1.Items.RemoveAt(selectedIndex);
        }
    }
}
