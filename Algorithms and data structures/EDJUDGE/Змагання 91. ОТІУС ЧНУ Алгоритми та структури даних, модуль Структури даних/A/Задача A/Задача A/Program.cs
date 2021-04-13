using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            int count = 0;
            string res = "";
            try
            {
                while ((array = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse)) != null)
                {
                    res += array[0] + array[1] + " ";
                    array = null;
                    count++;
                }
            }
            catch
            {
                int[] array2 = new int[count];
                array2 = Array.ConvertAll(res.Trim().Split(), int.Parse);
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(array2[i]);
                }
            }
            Console.ReadKey();
        }
    }
}