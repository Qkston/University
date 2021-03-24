using System;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firts matrix:");
            string[] value = { "4 2 1", "5 5 2", "5 9 7" };
            MyMatrix first_matrix = new MyMatrix(value);
            Console.WriteLine(first_matrix);
            
            Console.WriteLine("Second matrix:");
            string[] value2 = {"14 25 10", "16 2 4", "12 3 4"};
            MyMatrix second_matrix = new MyMatrix(value2);
            Console.WriteLine(second_matrix);

            Console.WriteLine("Summa:");
            Console.WriteLine(first_matrix + second_matrix);
            Console.WriteLine("Multiplication:");
            Console.WriteLine(first_matrix * second_matrix);

            Console.WriteLine("Transposed first matrix:");
            Console.WriteLine(first_matrix.GetTransponedCopy());
            Console.WriteLine("Transposed second matrix:");
            Console.WriteLine(second_matrix.GetTransponedCopy());

            Console.ReadKey();
        }
    }
}
