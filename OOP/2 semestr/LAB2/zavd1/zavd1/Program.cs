using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаємо параметри матриці
            Console.Write("Введiть кiлькiсть рядкiв в вашiй матрицi: ");
            int r = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введiть кiлькiсть стовпцiв в вашiй матрицi: ");
            int s = Convert.ToInt16(Console.ReadLine());

            int[,] Matrix = new int[r, s];         //Створюємо масив

            //Заповнюємо масив рандомними числами від -20 до 20
            Random random = new Random();
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    rand = random.Next(-20, 20);
                    Matrix[i, j] = rand;
                }
            }

            //Виводим матрицю на екран
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Знаходимо добуток кожного рядка і робимо виключення "0"
            int mul = 1;
            for (int i = 0; i < r; i++)
            {
                mul = 1;
                for (int j = 0; j < s; j++)
                {
                    mul *= Matrix[i, j];
                }
                if (mul == 0) continue;
                else Console.Write("В " + (i + 1) + " рядку добуток дорiвнює: " + mul);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
