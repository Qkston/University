using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            int[][] A;
            Random rnd = new Random();

            Console.WriteLine("Enter the number of rows matrixes");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns matrixes");
            cols = int.Parse(Console.ReadLine());

            //створення "зубчастої" матриці
            A = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                int rndcols = rnd.Next(cols);
                if (rndcols == 0)
                {
                    rndcols += 1;
                }
                A[i] = new int[rndcols];
            }

            //заповнення матриці випадковими числами
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    A[i][j] = rnd.Next(17);
                }
            }

            //вивід матриці на дисплей
            Console.WriteLine("Matrix A:");
            foreach (int[] u in A)
            {
                foreach (int v in u)
                {
                    Console.Write("{0, 4}", v);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nEnter to any key to continue...");
            Console.ReadKey();

            //Створення одномірної матриці з індексами та значеннями матриці А
            
            Console.WriteLine("Matrix V:");

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    //вивід матриці на дисплей
                    Console.Write("{0, 4}", i);
                    Console.Write("{0, 4}", j);
                    Console.Write("{0, 4}", A[i][j]);
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nEnter to any key to continue...");
            Console.ReadKey();

            //Створення прямокутної матриці B

            Console.WriteLine("Matrix B:");

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Array.Reverse(A[i]);
                    Array.Reverse(A[j]);
                    Console.Write("{0, 4}", i);
                    Console.Write("{0, 4}", j);
                    Console.Write("{0, 4}", A[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nEnter to any key to exit...");
            Console.ReadKey();
        }
    }
}

