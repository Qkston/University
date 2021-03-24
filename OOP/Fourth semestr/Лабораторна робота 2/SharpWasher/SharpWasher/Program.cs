using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Program
    {
        public delegate void CarsDelegate();

        public delegate void WashDelegate();
        static void Main(string[] args)
        {
            var cars = new CarsDelegate(Garage.Honda);
            cars += Garage.Bmw;
            cars += Garage.Audi;

            Console.WriteLine("Cars in list:");
            cars?.Invoke();

            Console.WriteLine();

            Console.Write("Enter any key for wash all cars");
            Console.ReadKey();

            var wash = new WashDelegate(Washer.Wash);
            wash?.Invoke();

            Console.ReadLine();
        }

    }
}
