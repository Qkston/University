using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace _91E
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            HashSet<int> set = new HashSet<int>();
            StringBuilder rez = new StringBuilder();

            for (int i = 0; i < s; i++)
            {
                string[] str = Console.ReadLine().Split();
                int p = 0;

                switch (str[0])
                {
                    case "ADD":
                        p = int.Parse(str[1]);
                        set.Add(p);
                        break;

                    case "COUNT":
                        rez.Append(set.Count.ToString() + '\n');
                        break;

                    case "PRESENT":
                        p = int.Parse(str[1]);
                        if (set.Contains(p))
                        {
                            rez.Append("YES" + '\n');
                        }
                        else
                        {
                            rez.Append("NO" + '\n');
                        }
                        break;
                }
            }
            Console.WriteLine(rez);
        }
    }
}