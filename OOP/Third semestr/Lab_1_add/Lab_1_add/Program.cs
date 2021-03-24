using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string exit = "Exit";

            while (isOpen)
            {
                Console.Write("Enter length side A: ");
                double a = int.Parse(Console.ReadLine());
                Console.Write("Enter length side B: ");
                double b = int.Parse(Console.ReadLine());
                Console.Write("Enter length side C: ");
                double c = int.Parse(Console.ReadLine());

                Console.Clear();

                TTriangle triangle = new TTriangle(a, b, c);
                triangle.CalculatePerimeter();
                triangle.CalculateSquare();
                triangle.ShowInfo();

                Console.WriteLine("\nEnter any button for continue, " +
                    "or enter the command 'Exit' to exit the program...");
                if (Console.ReadLine() == exit)
                {
                    isOpen = false;
                }
                
                Console.Clear();
            }
        }
    }

    class TTriangle
    {
        private double _perimeter;
        private double _square;

        protected double _a;
        protected double _b;
        protected double _c;

        public double A
        {
            get
            {
                return _a;
            }
            private set
            {
                if (_a > 0)
                    _a = value;
                else
                    _a = 0;
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            private set
            {
                if (_b > 0)
                    _b = value;
                else
                    _b = 0;
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            private set
            {
                if (_c > 0)
                    _c = value;
                else
                    _c = 0;
            }
        }

        public TTriangle(double a, double b, double c)
        {
            if (b + c > a)
                _a = a;
            if (a + c > b)
                _b = b;
            if (a + b > c)
                _c = c;
        }

        public void ShowInfo()
        {
            Console.Write("Perimeter of the triangle: " + _perimeter + "\n");
            Console.Write("Area of the triangle: " + Math.Round(_square, 2));
        }

        public double CalculatePerimeter()
        {
            if (A == 0 || B == 0 || C == 0)
                _perimeter = 0;
            else
                _perimeter = A + B + C;

            return _perimeter;
        }

        public void CalculateSquare()
        {
            double halfPerimeter = CalculatePerimeter();
            halfPerimeter /= 2;

            if (A == 0 || B == 0 || C == 0)
                _square = 0;
            else
                _square = Math.Sqrt(halfPerimeter * (halfPerimeter - A) *
                    (halfPerimeter - B) * (halfPerimeter - C));
        }
    }
}