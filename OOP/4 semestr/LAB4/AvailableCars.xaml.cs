using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace LAB4
{
    public partial class AvailableCars : Window
    {
        public AvailableCars()
        {
            InitializeComponent();
        }

        List<Car> allCar = new List<Car>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindowForm = new MainWindow();
            mainWindowForm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Car newCar = new Car();
            AddCar addCarWindow = new AddCar(newCar);
            if (addCarWindow.ShowDialog() == true)
            {
                listBox1.Items.Add(newCar.ToString());
                allCar.Add(newCar);
            }
            else
            {
                MessageBox.Show("Ваші дані не збережені");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer deSerializer = new XmlSerializer(typeof(List<Car>));
                using (TextReader reader = new StreamReader("all_car.xml"))
                {
                    allCar = (List<Car>)deSerializer.Deserialize(reader);
                }
                foreach (Car cars in allCar)
                {
                    listBox1.Items.Add(cars);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Не вдалося знайти файл із раніше збереженими даними");
                allCar = new List<Car>();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
            using (TextWriter writer = new StreamWriter("all_car.xml"))
            {
                serializer.Serialize(writer, allCar);
            }
        }

        private void listBox1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ChangeButton.IsEnabled = true;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= allCar.Count)
            {
                MessageBox.Show("Ви не обрали жодного автомобіля");
                return;
            }
            AddCar addCarWindow = new AddCar(allCar[listBox1.SelectedIndex]);
            if (addCarWindow.ShowDialog() == true)
            {
                listBox1.Items[idx] = allCar[listBox1.SelectedIndex].ToString();
            }
            else
            {
                MessageBox.Show("Ваші дані не збережені");
            }
        }

        private void DeleteCar_Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= allCar.Count)
            {
                MessageBox.Show("Ви не обрали жодного автомобіля");
                return;
            }
            allCar.RemoveAt(selectedIndex);
            listBox1.Items.RemoveAt(selectedIndex);
        }
    }
}
