using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace Lab_4_add
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            //Отримуємо список усіх файлів папки
            string[] files = Directory.GetFiles(@"E:\KS19\2 курс\ООП\Labs\Lab_4_add\Photos");
            //Отримуємо назву усіх файлів папки
            string[] names = Directory.GetFiles(@"E:\KS19\2 курс\ООП\Labs\Lab_4_add\Photos").Select(Path.GetFileName).ToArray();
            //Записуємо розширення файлів з якими будемо працювати
            Regex regexExtForImage = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png))$", RegexOptions.IgnoreCase);
            //Створюємо цикл для перебору файлів
            for (int i = 0; i < files.Length; i++)
            {
                try
                {
                    //Перевіряємо розширення файлів
                    if (regexExtForImage.IsMatch(Path.GetExtension(files[i])))
                    {
                        Bitmap file = (Bitmap)Bitmap.FromFile(files[i]);
                        //Дзеркальне відбивання (по горизонталі)
                        file.RotateFlip(RotateFlipType.Rotate180FlipY);
                        //Зберігаємо відредаговані файли
                        file.Save(@"E:\KS19\2 курс\ООП\Labs\Lab_4_add\Photos\Report\" + names[i].Split('.')[1] + "-mirrored.gif", ImageFormat.Gif);
                    }
                }
                //Перевірка на те, що файл не мiстить картинки
                catch (System.OutOfMemoryException)
                {
                    count++;
                }
            }
            Console.WriteLine("Всi фото в папцi вiдредаговано!");
            Console.Write("Натиснiть будь-яку клавiшу, щоб переглянути звiт ");
            Console.ReadKey();
            Console.WriteLine("Звiт: {0} файла(iв) успiшно вiдредаговано; {1} файла(iв) вiдредагувати невдалось*.", files.Length-count, count);
            if (count > 0)
            {
                Console.WriteLine("*Файл не мiстить картинки, хоча розширення правильне");
            }
            Console.ReadKey();
        }
    }
}
