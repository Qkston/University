using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Екзамен
{
    class Program
    {
        struct Collection
        {
            public string autor;
            public string book;
            public string year;
            public string publisher;
            public string location;

            public Collection(string autor_name, string book_name, string year_name, string publisher_name, string location_name)
            {
                autor = autor_name;
                book = book_name;
                year = year_name;
                publisher = publisher_name;
                location = location_name;
            }
        }

        static Collection[] ReadData(string linkName)
        {
            int count = File.ReadAllLines(linkName).Length;
            Collection[] coll = new Collection[count];
            string[] readText = File.ReadAllLines(linkName);
            char[] books;
            int j = 0;
            int y = 0;
            int c = 0;

            foreach (string str in readText)
            {
                books = str.ToCharArray();

                for(int i = 0; i < str.Length; i++)
                {
                    
                    if (books[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        for (; i < books.Length; i++)
                        {
                            if(books[i]== ' ')
                            {
                                break;
                            }
                            if(j == 0 && j <= 1)
                            {
                                coll[c].autor += books[i];
                            }
                            else if(j == 2)
                            {
                                coll[c].book += books[i];
                            }
                            else if(j == 3)
                            {
                                coll[c].year += books[i];
                            }
                            else if(j == 4)
                            {
                                coll[c].publisher += books[i];
                            }
                            else if(j >= 5 && j <= 6)
                            {
                                coll[c].location += books[i];
                            }
                        }
                    }
                    j++;
                }
                j = 0;
                c++;
            }
            for (int q = 0; q < coll.Length; q++)
            {
                for (int a = 0; a < coll[q].publisher.Length; a++)
                {
                    if(coll[q].publisher[a] == ' ' || coll[q].publisher[a] == '.' || coll[q].publisher[a] == ',')
                    {
                        continue;
                    }
                    if (y == 4)
                    {
                        coll[q].publisher += coll[q].publisher[a];
                    }
                    y++;
                }
                y = 0;
            }
            return coll;
        }

        static void Menu(Collection[] coll)
        {
            Console.WriteLine("Ранок");
            Console.WriteLine("Грамота");
            Console.Write("Введіть назву видання: ");
            
            string numb = Convert.ToString(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Collection[] collections = ReadData(@"D:\KS19\ПАЛМ\2 семестр\Екзамен\Book.txt");

            Menu(collections);

            Console.ReadKey();
        }
    }
}
