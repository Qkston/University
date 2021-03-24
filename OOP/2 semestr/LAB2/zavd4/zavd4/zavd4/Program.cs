using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть рядкiв в вашому масивi: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВаш масив: ");
            int[][] Mas = new int[n][];
            Random(ref Mas, ref n);

            Console.Write("\nВведiть рядок який хочете знищити (починаючи з 0): ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (n < k)
            {
                Console.WriteLine("Не правильно введений номер рядка!");
            }
            Console.WriteLine("\nВаш масив з видаленим {0}-м рядком: ", k);
            int[][] masOut = new int[Mas.Length - 1][];
            Remove(ref Mas, ref k, ref masOut);
            Output(masOut);

            Console.ReadKey();
        }

        static void Random(ref int[][] Mas, ref int n)
        {
            Random r = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = new int[n];
                for (int j = 1; j < Mas[i].Length; j++)
                {
                    Mas[i][j] = r.Next(0, 10);
                    Console.Write(Mas[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Remove(ref int[][] Mas , ref int k, ref int[][] masOut)
        {
            int v = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (i != k)
                {
                    masOut[v] = Mas[i];
                    v++;
                }
            }
        }

        static void Output(int[][] masOut)
        {
            for (int i = 0; i < masOut.Length; i++)
            {
                for (int j = 1; j < masOut.Length + 1; j++)
                {
                    Console.Write(masOut[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
