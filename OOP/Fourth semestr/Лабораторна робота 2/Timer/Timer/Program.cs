using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        public delegate int MyDelegate();
        static void Main(string[] args)
        {
            var myDelegate = new MyDelegate(Timer.Count);
            myDelegate();

            Console.ReadLine();
        }

    }
}
