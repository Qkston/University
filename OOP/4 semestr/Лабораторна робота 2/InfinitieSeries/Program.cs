using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InfinitieSeries
{
    class Program
    {
        public delegate double SumDelegate(double a, double r, int n);
        static void Main(string[] args)
        {
            Console.Write("Enter the number of calculating: ");
            var n = int.Parse(Console.ReadLine());
            var a = 1.0;
            var r = 1.0 / 2.0;

            Console.Write("1) 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...\n2) 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...\n3) 1 + 1/2 - 1/4 + 1/8 - 1/16 + ...\n");
            Console.Write("Choose infinite series: ");
            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    SumDelegate first = FirstSum;
                    Console.WriteLine($"Дурничка");
                    //Console.WriteLine($"Result: {first?.Invoke(a, r, n)}");
                    break;
                case 2:
                    Console.Clear();
                    SumDelegate second = SecondSum;
                    //Console.WriteLine($"Result: {second?.Invoke(a, r, n)}");
                    Console.WriteLine($"Дурничка");

                    break;
                case 3:
                    Console.Clear();
                    SumDelegate third = ThirdSum;
                    Console.WriteLine($"Дурничка");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Something went wrong!");
                    break;
            }

            Console.ReadLine();
        }

        private static double FirstSum(double a, double r, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += a;
                a *= r;
            }
            return Math.Round(sum, 2);
        }
        private static double SecondSum(double a, double r, int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return Math.Round(sum, 2);
        }
        private static double Factorial(double num)
        {
            double res = 1;
            for (double i = num; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }
        private static double ThirdSum(double a, double r, int n)
        {
            var sum = 0.0;
            var PlusOrMinus = true;
            var changingSignsCount = -1;
            double tmp = sum + a;

            for (int i = 1; i <= n; i++)
            {
                changingSignsCount++;

                if (PlusOrMinus)
                {
                    sum += tmp;
                }
                else
                {
                    sum -= tmp;
                }
                if (changingSignsCount == 1)
                {
                    PlusOrMinus = !PlusOrMinus;
                    changingSignsCount = 0;
                }

                tmp = a *= r;
            }
            return Math.Round(sum, 2);
        }
    }
}
