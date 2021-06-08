﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace LAB4
{
    public partial class CarsInRental : Window
    {
        public CarsInRental()
        {
            InitializeComponent();

            rentals.ForEach(rental =>
            {
                listBox1.Items.Add(rental.ToShortString(idx));
            });
        }

        List<Vehicle> allVehicles = new List<Vehicle>();
        List<Rental> rentals = new List<Rental>();

        private int idx;

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

        private void MoreDetailButton_Click(object sender, RoutedEventArgs e)
        {
            idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= allVehicles.Count)
            {
                MessageBox.Show("Ви не обрали жодного автомобіля");
                return;
            }
            else
            {
                MessageBox.Show("ShortInfo");
            }
        }

        private void DeleteCar_Button_Click(object sender, RoutedEventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= allVehicles.Count)
            {
                MessageBox.Show("Ви не обрали жодного автомобіля");
                return;
            }
            allVehicles.RemoveAt(idx);
            listBox1.Items.RemoveAt(idx);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer deSerializer = new XmlSerializer(typeof(List<Vehicle>));
                using (TextReader reader = new StreamReader("all_car_in_rental.xml"))
                {
                    allVehicles = (List<Vehicle>)deSerializer.Deserialize(reader);
                }
                foreach (Vehicle vehicle in allVehicles)
                {
                    listBox1.Items.Add(vehicle);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Не вдалося знайти файл із раніше збереженими даними");
                allVehicles = new List<Vehicle>();
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>));
            using (TextWriter writer = new StreamWriter("all_car_in_rental.xml"))
            {
                serializer.Serialize(writer, allVehicles);
            }
        }
    }
}
