using System;

namespace QuickSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            QuickSort quickSort = new QuickSort();

            int[] array = {0, -55, -34, -99, -60, -64, 33, 79, 48, -58};

            quickSort.Sort(array, 0, array.Length - 1);

            foreach (var value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}