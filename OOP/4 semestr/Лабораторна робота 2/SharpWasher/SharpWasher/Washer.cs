using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Washer
    {
        public static void Wash()
        {
            Console.WriteLine("Thank you! All cars have been washed!");

            var honda = new Garage("Honda", 5, 1);
            Console.WriteLine($"Name of car: {honda.Name_of_Car}, Level of dirty: {honda.Level_of_Dirty * 0}/5, Place in garage: {0}");

            var bmw = new Garage("BMW", 4, 2);
            Console.WriteLine($"Name of car: {bmw.Name_of_Car}, Level of dirty: {bmw.Level_of_Dirty * 0}/5, Place in garage: {0}");

            var audi = new Garage("Audi", 1, 3);
            Console.WriteLine($"Name of car: {audi.Name_of_Car}, Level of dirty: {audi.Level_of_Dirty * 0}/5, Place in garage: {0}");
        }

    }
}
