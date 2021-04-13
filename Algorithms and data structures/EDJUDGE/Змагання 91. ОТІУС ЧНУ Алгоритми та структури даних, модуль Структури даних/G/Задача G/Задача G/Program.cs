using System;
using System.Collections.Generic;

namespace Задача_G
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> client = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                switch (temp[0])
                {
                    case "1":
                    {
                        if (client.ContainsKey(temp[1])) client[temp[1]] += Convert.ToInt32(temp[2]);
                        else client.Add(temp[1], Convert.ToInt32(temp[2]));
                        break;
                    }
                    case "2":
                    {
                        if (client.ContainsKey(temp[1])) Console.WriteLine(client[temp[1]]);
                        else Console.WriteLine("ERROR");
                        break;
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
