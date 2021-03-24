using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        struct Student

        {
            public string stud_name;
            public string stud_surname;
            public string stud_patronomic;

            public string stud_rating;

            public string stud_stipend;
        }

        static Student[] ReadData(string file_Name)
        {
            int count = File.ReadAllLines(file_Name).Length;
            Student[] stud = new Student[count];
            string[] readText = File.ReadAllLines(file_Name);
            char[] student;

            int j = 0;
            int c = 0;

            foreach (string str in readText)
            {
                student = str.ToCharArray();

                for (int i = 0; i < str.Length; i++)
                {

                    if (student[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        for (; i < student.Length; i++)
                        {

                            if (student[i] == ' ')
                            {
                                break;
                            }
                            if (j == 0)
                            {
                                stud[c].stud_surname += student[i];
                            }
                            else if (j == 1)
                            {
                                stud[c].stud_name += student[i];
                            }
                            else if (j == 2)
                            {
                                stud[c].stud_patronomic += student[i];
                            }
                            else if (j >= 5 && j <= 7)
                            {
                                stud[c].stud_rating += student[i];
                            }
                            else if (j == 8)
                            {
                                stud[c].stud_stipend += student[i];
                            }
                        }
                    }
                    j++;
                }

                j = 0;
                c++;

            }

            return stud;
        }

        static void runMenu(Student[] stud)
        {
            Console.WriteLine("Студенти:");

            for (int i = 0; i < stud.Length; i++)
            {
                int srating = Convert.ToInt32(stud[i].stud_rating);
                int sstipend = Convert.ToInt32(stud[i].stud_stipend);

                if (sstipend == 0 && srating % 2 != 0)
                {
                    Console.WriteLine(stud[i].stud_surname + " " + stud[i].stud_name + " " + stud[i].stud_patronomic);
                }
            }
        }

        static void Main(string[] args)
        {
            string s = @"\";
            Console.WriteLine("Вивести прiзвища студентiв, що мають всi задовiльнi оцiнки i не одержують стипендiю.");
            Console.WriteLine("");
            Console.Write("Введiть шлях до файлу (.txt) в якому потрiбно зробити перевiрку (Приклад: D:{0}База даних учнiв.txt): ", s);
            string way = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");

            Student[] studs = ReadData(@way);

            runMenu(studs);

            Console.ReadKey();
        }

    }
}