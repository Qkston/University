using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    struct MyTime
    {
        public int hour, minute, second;
        public MyTime(int h, int m, int s)
        {
            hour = h; minute = m; second = s;
        }
        public override string ToString()
        {
            return string.Format("{0}:{1:00}:{2:00}", hour, minute, second);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyTime t;  //головний час

            t.hour = 16;
            t.minute = 39;
            t.second = 43;

            MyTime mt1;  //перший момент часу

            mt1.hour = 17;
            mt1.minute = 20;
            mt1.second = 36;

            MyTime mt2;  //другий момент часу

            mt2.hour = 13;
            mt2.minute = 30;
            mt2.second = 5; 

            Console.WriteLine("{0} - час  (в секундах - {1})", t, TimeSinceMidnight(t));
            Console.WriteLine("{0} - додає до часу одну секунду", AddOneSecond(t));
            Console.WriteLine("{0} - додає до часу одну хвилину", AddOneMinute(t));
            Console.WriteLine("{0} - додає до часу одну годину", AddOneHour(t));
            Console.WriteLine("{0} - додає до часу n-кiлькiсть секунд", AddSeconds(t, 17));
            Console.WriteLine("Перший момент часу {0} - другий момент часу {1} ({2} - рiзниця мiж цими моментами)", mt1, mt2, TimeSinceMidnight(Difference(mt1, mt2)));
            Console.WriteLine("Введiть спершу години, потiм з нового рядка хвилини i так само секунди: ");

            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            MyTime mt;
            mt.hour = array[0];
            mt.minute = array[1];
            mt.second = array[2];

            Console.WriteLine("{0} - {1}", mt, WhatLesson(mt));

            Console.ReadKey();
        }
        static int TimeSinceMidnight(MyTime t)
        {
            return t.hour * 3600 + t.minute * 60 + t.second;
        }
        static MyTime TimeSinceMidnight(int t)
        {
            int secPerDay = 60 * 60 * 24;                  // приводимо t до проміжку, можливого в межах однієї доби,
            t = ((t % secPerDay) + secPerDay) % secPerDay; // якщо воно надто велике або від’ємне
            int h = t / 3600;                              // (в т.ч. й надто велике за модулем від’ємне) 
            int m = (t / 60) % 60;
            int s = t % 60;
            return new MyTime(h, m, s);
        }
        static MyTime AddOneSecond(MyTime t)
        {
            return TimeSinceMidnight(TimeSinceMidnight(t) + 1);
        }
        static MyTime AddOneMinute(MyTime t)
        {
            return TimeSinceMidnight(TimeSinceMidnight(t) + 60);
        }
        static MyTime AddOneHour(MyTime t)
        {
            return TimeSinceMidnight(TimeSinceMidnight(t) + 3600);
        }
        static MyTime AddSeconds(MyTime t, int s)
        {
            return TimeSinceMidnight(TimeSinceMidnight(t) + s);
        }
        static int Difference(MyTime mt1, MyTime mt2)
        {
            return TimeSinceMidnight(mt1) - TimeSinceMidnight(mt2);
        }
        static string WhatLesson(MyTime mt)
        {
            MyTime F_les = new MyTime(8, 0, 0);
            if(Difference(mt, F_les) <= 0)
            {
                return "Пари ще не почились";
            }
            int[] breaksLengthsMinutes = { 20, 20, 20, 20, 10, 0 };
            //int whatLes = 1;
            for(int lessNumb = 0; lessNumb < breaksLengthsMinutes.Length; lessNumb++)
            {
                F_les = AddSeconds(F_les, 80 * 60); //час однієї пари
                if (Difference(mt, F_les) < 0) 
                {
                    return string.Format("Зараз {0}-а(я) пара", lessNumb + 1);
                }
                F_les = AddSeconds(F_les, breaksLengthsMinutes[lessNumb] * 60); //час перерви (20 хвилин, після 5-ої пари - 10 хвилин)
                if(lessNumb == breaksLengthsMinutes.Length - 1)
                {
                    break;
                }
                if (Difference(mt, F_les) <= 0) 
                {
                    return string.Format("Зараз перерва мiж {0}-ю та {1}-ю парами", lessNumb + 1, lessNumb + 2);
                }
            }
            return "Пари вже закiнчились";
        }
    }
}