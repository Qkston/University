using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_task
{
    class Program
    {
        private delegate double MyDelegate(double value);

        static void Main(string[] args)
        {
            MyDelegate[] mD =
            {
                num => Math.Sqrt(Math.Abs(num)),
                num => Math.Pow(num, 3),
                num => num + 3.5,
                num => Math.Cos(num)
            };
            Dictionary<double, MyDelegate> switcher = new Dictionary<double, MyDelegate>
            {
                {0, mD[0]},
                {1, mD[1]},
                {2, mD[2]},
                {3, mD[3]}
            };

            Console.WriteLine("Enter data as long as they are of type 0 x or 1 x or 2 x.");
            Console.WriteLine("0 -- sqrt(abs(x))\n1 -- x^3\n2 -- x + 3,5\n3 -- cos(x)");
            Console.WriteLine("\nIf the line have incorrect this format, program will ending.");

            while (true)
            {
                try
                {
                    var inputDataString = Console.ReadLine();
                    string[] stringArray = inputDataString.Split();
                    var key = int.Parse(stringArray[0]);
                    var value = double.Parse(stringArray[1]);
                    var a = switcher[key];
                    Console.WriteLine(a(value));
                }
                catch (Exception e)
                {
                    Console.WriteLine(
                        $"Something went wrong! {e.Message}\nThe program has completed it's work. Goodbye!");
                    break;
                }
            }

            Console.ReadLine();
        }
         
    }
}
