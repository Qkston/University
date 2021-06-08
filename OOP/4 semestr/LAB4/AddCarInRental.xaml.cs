using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace LAB4
{
    public partial class AddCarInRental : Window
    {
        public Vehicle theVehicle;
        List<Car> allCars = new List<Car>();

        public AddCarInRental(Vehicle vehicle)
        {
            InitializeComponent();

            theVehicle = vehicle;
            
            if (theVehicle != null && theVehicle.Car != null)
            {
                StartDate_DatePicker.Text = theVehicle.StartHireTime.ToShortDateString();
                NumberOfCar_TextBox.Text = theVehicle.NumberOfCar.ToString();
                Price_TextBox.Text = theVehicle.Price.ToString();
                RentalPeriod_TextBox.Text = theVehicle.RentalPeriod.ToString();
                Car_ComboBox.SelectedIndex = Car_ComboBox.Items.IndexOf(vehicle.Category.ToString());
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                theVehicle.StartHireTime = StartDate_DatePicker.DisplayDate;
                theVehicle.NumberOfCar = Int32.Parse(NumberOfCar_TextBox.Text);
                theVehicle.RentalPeriod = Int32.Parse(RentalPeriod_TextBox.Text);

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer deSerializer = new XmlSerializer(typeof(List<Car>));
                using (TextReader reader = new StreamReader("all_car.xml"))
                {
                    allCars = (List<Car>)deSerializer.Deserialize(reader);
                }
                foreach (Car cars in allCars)
                {
                    Car_ComboBox.Items.Add(cars.Model);
                    Price_TextBox.Text = $"{cars.Price.ToString()} $/добу";
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Не вдалося знайти файл із автомобілями");
                allCars = new List<Car>();
            }
        }
    }
}
