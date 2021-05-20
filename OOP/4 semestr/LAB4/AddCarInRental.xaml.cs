using System;
using System.Collections.Generic;
using System.Windows;

namespace LAB4
{
    public partial class AddCarInRental : Window
    {
        public Vehicle TheVehicle;
        List<Vehicle> vehicles;
        public AddCarInRental(Vehicle vehicle)
        {
            InitializeComponent();
            
            TheVehicle = vehicle;

            if (TheVehicle != null && TheVehicle.Car != null)
            {
                NumberOfCar_TextBox.Text = TheVehicle.NumberOfCar.ToString();
                Price_TextBox.Text = TheVehicle.Price.ToString();
                RentalPeriod_TextBox.Text = TheVehicle.RentalPeriod.ToString();
                Car_ComboBox.SelectedIndex = Car_ComboBox.Items.IndexOf(vehicle.Category.ToString());
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = Car_ComboBox.SelectedIndex;
            try
            {
                TheVehicle.NumberOfCar = Convert.ToChar(NumberOfCar_TextBox.Text);
                TheVehicle.Price = int.Parse(Price_TextBox.Text);
                TheVehicle.RentalPeriod = int.Parse(RentalPeriod_TextBox.Text);
                TheVehicle.Category = vehicles[selectedIndex];

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
