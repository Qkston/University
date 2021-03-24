using System;

namespace Lab_2_Zavd_2
{
    public class TSquare
    {
        public double leght;
        public double leght2;

        public TSquare()
        {
            leght = 0;
            Value_Leght();
        }
        public TSquare(double leght)
        {
            this.leght = leght;
        }
        public override string ToString()
        {
            return "Довжина сторони: " + leght;
        }

        public double Leght
        {
            get { return leght; }
            set
            {
                leght = value;
            }
        }
        public virtual void Value_Leght()
        {
            Console.Write("Введiть довжину сторони квадрата: ");
            leght = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(ToString());
            Console.WriteLine("Площа квадрата: " + Square(leght));
            Console.WriteLine("Периметр квадрата: " + Perimeter(leght));
            Console.WriteLine();
            Console.Write("Введiть довжину сторони другого квадрата для порiвняння: ");
            leght2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Квадрат з довжиною " + Comparison(leght, leght2) + " бiльший або дорiвнює iншому");
            Console.WriteLine();
            Console.WriteLine("Сумма довжин сторiн двох квадратiв: " + Summa(leght, leght2));
            Console.WriteLine("Рiзниця довжин сторiн двох квадратiв: " + Subtraction(leght, leght2));
            Console.WriteLine("Добуток довжин сторiн двох квадратiв: " + Multiplication(leght, leght2));

        }

        public double Square(double leght)
        {
            return Math.Pow(leght, 2);
        }

        public double Perimeter(double leght)
        {
            return leght * 4;
        }

        public double Comparison(double leght, double leght2)
        {
            if (leght >= leght2)
            {
                return leght;
            }
            else
            {
                return leght2;
            }
        }

        public double Summa(double leght, double leght2)
        {
            return (leght * 4) + (leght2 * 4);
        }

        public double Subtraction(double leght, double leght2)
        {
            return (leght * 4) - (leght2 * 4); ;
        }

        public double Multiplication(double leght, double leght2)
        {
            return (leght * 4) * (leght2 * 4); ;
        }
    }

    public class TCube : TSquare
    {
        public TCube()
        {
            PrintAll();
        }

        public double Size_Leght(double leght)
        {
            return Math.Pow(leght, 3);
        }
        public double Size_Leght2(double leght2)
        {
            return Math.Pow(leght2, 3);
        }

        public void PrintAll()
        {
            Console.WriteLine();
            Console.WriteLine("Об'єм куба з довжиною сторони " + leght + ": " + Size_Leght(leght));
            Console.WriteLine("Об'єм куба з довжиною сторони " + leght2 + ": " + Size_Leght2(leght2));
        }
    }
}