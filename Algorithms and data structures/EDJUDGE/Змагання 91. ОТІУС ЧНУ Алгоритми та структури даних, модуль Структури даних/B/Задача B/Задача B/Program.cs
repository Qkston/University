using System;
using System.Resources;

namespace Задача_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] s = Console.ReadLine().Split();

            Graph[] array = new Graph[int.Parse(s[1])];
            for (int i = 0; i < array.Length; i++)
            {
                string[] s1 = Console.ReadLine().Split();
                array[i] = new Graph(int.Parse(s1[0]), int.Parse(s1[1]), int.Parse(s1[2]), i + 1);
            }
            Array.Sort(array);
            Console.WriteLine();
            foreach (Graph value in array)
            {
                Console.WriteLine(value);
            }
        }


        struct Graph : IComparable<Graph>
        {
            public int string_1, fin_1, length_1, index_1;

            public Graph(int s, int f, int l, int i)
            {
                this.string_1 = s;
                this.fin_1 = f;
                this.length_1 = l;
                this.index_1 = i;
            }

            public int CompareTo(Graph object_1)
            {
                if (this.length_1 == object_1.length_1)
                {
                    return 0;
                }

                return this.length_1.CompareTo(object_1.length_1);
            }

            public override string ToString()
            {
                return string_1 + " " + fin_1 + " " + length_1 + " " + index_1;
            }
        }
    }
}
