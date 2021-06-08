using System;
using System.Data;

namespace LAB4
{
    public class Vehicle
    {
        private TypeValue category;
        private Car car;
        private DateTime startHireTime;
        private int price, rentalPeriod, numberOfCar;

        public TypeValue Category
        {
            get => category;
            set => category = value;
        }

        public Car Car
        {
            get => car;
            set => car = value;
        }

        public DateTime StartHireTime
        {
            get => startHireTime;
            set => startHireTime = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public int RentalPeriod
        {
            get => rentalPeriod;
            set => rentalPeriod = value;
        }

        public int NumberOfCar
        {
            get => numberOfCar;
            set => numberOfCar = value;
        }

        public int GetRentalPeriod()
        {
            return rentalPeriod;
        }

        public int GetPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return $"Дата початку прокату: {startHireTime.ToShortDateString()}.\nВартість прокату: {price} $.\nТривалість прокату: {rentalPeriod} діб.\nНомер автомобіля: {numberOfCar}";
        }
    }
}
