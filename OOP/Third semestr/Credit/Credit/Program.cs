using System;

namespace zalik
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Шевченко Т.Г.";
            string nazv1 = "Кобзар";
            int data1 = 1840;
            iskus _name1 = new iskus(name1, nazv1, data1);
            _name1.ekran();
            Console.WriteLine();
            string name2 = "Бах Й.С.";
            string nazv2 = "Air on the G String";
            int data2 = 1731;
            string key2 = "До мажор";
            music _name2 = new music(name2, nazv2, data2, key2);
            _name2.ekran();
            Console.WriteLine();
            string name3 = "Оркестр Поля Морiа";
            string nazv3 = "Somethin’ Stupid";
            int data3 = 1967;
            string key3 = "Мажор";
            int kol3 = 10;
            music_or _name3 = new music_or(name3, nazv3, data3, key3, kol3);
            _name3.ekran();
            Console.WriteLine();
            string name4 = "Пабло Пiкасо";
            string nazv4 = "Гернiка";
            int data4 = 1937;
            int h4 = 1280;
            int w4 = 720;
            kart _name4 = new kart(name4, nazv4, data4, h4, w4);
            _name4.ekran();

        }
    }
}
