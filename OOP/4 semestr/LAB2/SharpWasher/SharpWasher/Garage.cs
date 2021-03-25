using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Garage : Car
    {
        public Garage(string name_of_car, int level_of_Dirty, int place_in_queue) : base(name_of_car, level_of_Dirty, place_in_queue) { }

        public static void Honda()
        {
            var honda = new Garage("Honda", 5, 1);

            Console.WriteLine($"Name of car: {honda.Name_of_Car}, Level of dirty: {honda.Level_of_Dirty}/5, Place in garage: {honda.Place_In_Queue}");
        }
        public static void Bmw()
        {
            var bmw = new Garage("BMW", 4, 2);

            Console.WriteLine($"Name of car: {bmw.Name_of_Car}, Level of dirty: {bmw.Level_of_Dirty}/5, Place in garage: {bmw.Place_In_Queue}");
        }
        public static void Audi()
        {
            var audi = new Garage("Audi", 1, 3);

            Console.WriteLine($"Name of car: {audi.Name_of_Car}, Level of dirty: {audi.Level_of_Dirty}/5, Place in garage: {audi.Place_In_Queue}");
        }

    }
}
