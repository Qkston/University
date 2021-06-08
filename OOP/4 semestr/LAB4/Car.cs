using System;
using System.Collections.Generic;

namespace LAB4
{
    public class Car
    {
        private string company, model;
        private int year, price;
        public TypeValue category;

        public TypeValue Category
        {
            get => category;
            set => category = value;
        }

        public string Company
        {
            get => company;
            set => company = value;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public int Year
        {
            get => year;
            set
            {
                if (value >= 1886)
                {
                    year = value;
                }

                else throw new ArgumentException();
            }
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public override string ToString()
        {
            return $"Компанія: {company}.\nМодель: {model}.\nРік розробки: {year} р.\nВартість: {price} $.\nКатегорія: {category}";
        }
    }
}
