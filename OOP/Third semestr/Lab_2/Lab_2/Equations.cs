using System;

namespace Lab_2
{
    public class Equations
    {
        public double a, b, c, d, e, f;

        public Equations()
        {
            PrintAll();
        }
        public virtual void Value()
        {
            Console.Write("Введiть значення a: ");
            double a = double.Parse(Console.ReadLine());
            this.a = a;
            Console.Write("Введiть значення b: ");
            double b = double.Parse(Console.ReadLine());
            this.b = b;
            Console.Write("Введiть значення c: ");
            double c = double.Parse(Console.ReadLine());
            this.c = c;
            Console.Write("Введiть значення d: ");
            double d = double.Parse(Console.ReadLine());
            this.d = d;
            Console.Write("Введiть значення e: ");
            double e = double.Parse(Console.ReadLine());
            this.e = e;
            Console.Write("Введiть значення f: ");
            double f = double.Parse(Console.ReadLine());
            this.f = f;

        }
        public void PrintAll()
        {
            Value();

            Console.WriteLine();

            Console.WriteLine("Ваша система рiвнянь:");
            Console.WriteLine("{0}x+{1}y={2}", a, b, c);
            Console.WriteLine("{0}x+{1}y={2}", d, e, f);

            Console.WriteLine();

            Console.WriteLine("Натиснiть будь-яку клавiшу, щоб розв'язати дану систему рiвнянь");
            Console.ReadKey();
            Solution(a, b, c, d, e, f);
        }

        public static void Solution(double a, double b, double c, double d, double e, double f)
        {
            double x = (c * e - b * f) / (a * e - b * d);
            double y = (a * f - c * d) / (a * e - b * d);
            Console.WriteLine("\nX = " + x + "; Y = " + y);
        }
    }
}