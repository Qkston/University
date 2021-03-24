using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavd3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введiть розмiр масиву: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваш масив: ");
            int[] mas = new int[r];
            Random(ref mas);
            Output(mas);
            Console.WriteLine();
            
            Console.Write("\nВведiть кiлькiсть елементiв якi хочете знищити: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введiть номер елементу з якого почати знищення (починаючи з 0): ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Виводимо новий масив:");
            int[] newmas = new int[mas.Length - n];
            Resize(ref newmas, ref mas, ref k, ref n);
            Output(newmas);

            Console.ReadKey();
        }

        static void Random(ref int[] mas) 
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 50);
            }
        }

        static void Resize(ref int[] newmas, ref int[] mas, ref int k, ref int n)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i < k || i >= k + n)
                {
                    newmas[count] = mas[i];
                    count++;
                }
            }
        }

        static void Output(int[] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}