using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 варіант; сортування вибору
            Console.WriteLine("Sorting by selections");

            Console.WriteLine("Enter the number of digits in your array:");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            int sum = 0;
            Console.WriteLine();

            //Заповнюємо масив випадковим чином (методом рандому)
            Console.WriteLine("Random:");
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-50, 50);
                Console.Write(mas[i] + " ");

                if(mas[i] > 10)
                {
                    sum += mas[i];    //Знаходимо суму чисел більших за 10
                }
            }
            Console.WriteLine();

            //Сортуємо масив методом вибору
            Console.WriteLine("\nSorting:");
            Sorting(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();

            //Виводимо результат суми
            Console.WriteLine("\nSumma: ");
            Console.WriteLine(sum);

            Console.ReadKey();
        }

        public static int[] Sorting(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            return mas;
        }
        
    }
}
