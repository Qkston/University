using System;
using System.Data;
using System.IO;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_number, second_number;
            int a, b;
            int multiplication = new Int32();
            long sum = 0;
            int good_file = 0;

            //Створюємо цикл, який перебирає всі файли в папці
            for (int i = 10; i < 30; i++)
            {
                string way = @"E:\KS19\2 курс\ООП\Labs\Lab_4\DB\" + i + ".txt";

                //Зчитуємо інформацію в файлах, які лежать в папці
                try
                {
                    StreamReader f = new StreamReader(way);
                    first_number = f.ReadLine();
                    a = Convert.ToInt32(first_number);
                    second_number = f.ReadLine();
                    b = Convert.ToInt32(second_number);

                    //Використовуємо оператор 'checked', для перевірки переповнення при виконанні арифметичних операцій
                    checked
                    {
                        multiplication = a * b;
                    }

                    Console.WriteLine("Числа у файлi {2}.txt: {0}, {1}", first_number, second_number, i);
                    Console.WriteLine("Добуток чисел у цьому файлi: " + multiplication);
                    Console.WriteLine();

                    //Записуємо раніше знайдений добуток чисел у зчитуваних файлах у змінну 'sum' для подальшого знаходження середнього арифметичного числа
                    sum += multiplication;
                    
                    good_file++;
                    f.Close();
                }
                //Перевірка відсутніх файлів та їх запис в окремий текстовий файл
                catch (System.IO.FileNotFoundException)
                {
                    using (StreamWriter no_file = new StreamWriter(@"E:\KS19\2 курс\ООП\Labs\Lab_4\DB\no_file.txt", true, System.Text.Encoding.Default))
                    {
                        no_file.WriteLine(i + ".txt");
                    }
                }
                //Перевірка файлів, з перших двох рядків яких неможливо прочитати два цілі числа у звичайному десятковому записі та запис їх в окремий текстовий файл
                catch (System.FormatException)
                {
                    using (StreamWriter bad_data = new StreamWriter(@"E:\KS19\2 курс\ООП\Labs\Lab_4\DB\bad_data.txt", true, System.Text.Encoding.Default))
                    {
                        bad_data.WriteLine(i + ".txt");
                    }
                }
                //Перевірка файлів, у яких добуток прочитаних двох файлів не поміщається у 32-бітовий тип int та запис їх в окремий текстовий файл
                catch (System.OverflowException)
                {
                    using (StreamWriter overflow = new StreamWriter(@"E:\KS19\2 курс\ООП\Labs\Lab_4\DB\overflow.txt", true, System.Text.Encoding.Default))
                    {
                        overflow.WriteLine(i + ".txt");
                    }
                }
            }
            //Знаходимо кількість "нормальних" файлів, середнє арифметичне всих чисел всих файлів та виводимо їх на екран
            Console.WriteLine("Кiлькiсть нормально-прочитаних файлiв: {0}", good_file);
            Console.WriteLine("Середнє арифметичне дорiвнює - {0}", sum / (double)good_file);
            Console.ReadKey();
        }
    }
}
