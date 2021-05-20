using System;
using System.Data;

namespace LAB4
{
    public class Vehicle
    {
        private Category category;
        private Car car;
        private DateTime startHireTime;
        private int price, rentalPeriod;
        private char numberOfCar;

        public Category Category
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

        public char NumberOfCar
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
            return $"Автомобіль: {car}.\nДата початку прокату: {startHireTime}.\nВартість прокату: {price} $.\nТривалість прокату: {rentalPeriod} доба(и).\nНомер автомобіля: {numberOfCar}";
        }
    }
}
