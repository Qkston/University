using System.Windows;

namespace LAB4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AvailableCars availableCarsWindow = new AvailableCars();
            availableCarsWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CarsInRental carsInRentalWindow = new CarsInRental();
            carsInRentalWindow.Show();
            this.Close();
        }
    }
}
