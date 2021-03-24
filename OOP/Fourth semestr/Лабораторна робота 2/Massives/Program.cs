using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Massives
{
    class Program
    {
        public delegate void DivisonDelegate(int value, int value1, int[,] value2);

        public delegate void MassiveDelegate(int value, int value1, int[,] value2);
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            var rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            var columns = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, columns];

            var massiveDelegate = new MassiveDelegate(Massive);
            massiveDelegate?.Invoke(rows, columns, array);

            var divisonDelegate = new DivisonDelegate(Division);
            divisonDelegate?.Invoke(rows, columns, array);

            Console.ReadLine();
        }

        public static void Division(int rows, int columns, int[,] array)
        {
            Console.Write("The numbers which division in number 3 and number 7: ");
            moysha:
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 3 == 0 && array[i, j] % 7 == 0)
                    {
                        var result = array[i, j];
                        Console.Write($"{result} ");
                        goto moysha;
                    }
                }
            }
        }

        public static void Massive(int rows, int columns, int[,] array)
        {
            var rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rnd.Next(100);
                    Console.Write("{0, 4}", array[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
