using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Car
    {
        public string Name_of_Car { get; set; }

        public int Level_of_Dirty { get; set; }

        public int Place_In_Queue { get; set; }

        public Car(string name_of_car, int level_of_Dirty, int place_In_Queue)
        {
            Name_of_Car = name_of_car;
            Level_of_Dirty = level_of_Dirty;
            Place_In_Queue = place_In_Queue;
        }

    }
}
