using System;
using System.Data;

namespace LAB4
{
    class Vehicle
    {
        private Category category;
        private Car car;
        private DateTime startHireTime;
        private int price, rentalPeriod;
        private char numberOfCar;

        public Vehicle(Category category, Car car, DateTime startHireTime, int price, int rentalPeriod, char numberOfCar)
        {
            this.category = category;
            this.car = car;
            this.startHireTime = startHireTime;
            this.price = price;
            this.rentalPeriod = rentalPeriod;
            this.numberOfCar = numberOfCar;
        }

        public int GetRentalPeriod()
        {
            return rentalPeriod;
        }

        public int GetPrice()
        {
            return price;
        }
    }
}
