using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            string[] str = Console.ReadLine().Trim().Split();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }

            quickSort(arr, 0, arr.Length - 1);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void quickSort(int[] array, int low, int high)
        {
            if (array.Length == 0)
                return;

            if (low >= high)
                return;

            int middle = low + (high - low) / 2;
            int opora = array[middle];

            int i = low, j = high;
            while (i <= j)
            {
                while (array[i] < opora)
                {
                    i++;
                }

                while (array[j] > opora)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (low < j)
                quickSort(array, low, j);

            if (high > i)
                quickSort(array, i, high);
        }
    }
}