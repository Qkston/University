using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd2
{
    class Program
    {
        public static void Main()
        {
            //Задаємо параметри матриці
            Console.Write("Введiть кiлькiсть рядкiв в вашiй матрицi: ");
            int r = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введiть кiлькiсть стовпцiв в вашiй матрицi: ");
            int s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            int[,] Matrix = new int[r, s];         //Створюємо масив

            //Заповнюємо масив рандомними числами від -20 до 20
            Console.WriteLine("Початкова матриця:");
            Random random = new Random();
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    rand = random.Next(-20, 20);
                    Matrix[i, j] = rand;
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Вiдсортована матриця:");
            MinIndexAndSorting(Matrix);

            Console.ReadKey();
        }
        public static int[,] MinIndexAndSorting(int[,] Matrix)
        {
            //Знаходимо мінімальний елемент
            int min;
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                min = int.MaxValue;
                int i1 = 0;
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    if (min > Matrix[i, j])
                    {
                        min = Matrix[i, j];
                        i1 = i;
                    }
                }
                int temp = Matrix[0, j];
                Matrix[0, j] = min;
                Matrix[i1, j] = temp;
            }

            //Виводимо відсортовану матрицю
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return Matrix;
        }
    }
}
