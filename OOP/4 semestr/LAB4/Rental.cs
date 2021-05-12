using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Annotations;

namespace LAB4
{
    class Rental
    {
        private string nameOfCompany;
        List<Vehicle> completedOrders = new List<Vehicle>();

        public Rental(string nameOfCompany, List<Vehicle> completedOrders)
        {
            this.nameOfCompany = nameOfCompany;
            this.completedOrders = completedOrders;
        }
        public Rental(string nameOfCompany)
        {
            this.nameOfCompany = nameOfCompany;
        }

        public void Add(Vehicle vehicle)
        {
            completedOrders.Add(vehicle);
        }

        public string ToShortString(int i)
        {
            return $"{this.nameOfCompany} {completedOrders[i].GetRentalPeriod()} {completedOrders[i].GetPrice()}";
        }

    }
}
