using System.Windows;

namespace LAB4
{
    public partial class CarsInRental : Window
    {
        public CarsInRental()
        {
            InitializeComponent();
        }

        private void BackButton_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindowForm = new MainWindow();
            mainWindowForm.Show();
            this.Close();
        }
    }
}
