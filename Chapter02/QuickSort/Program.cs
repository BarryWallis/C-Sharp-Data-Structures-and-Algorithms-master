using System;

using SortLib;

namespace QuickSort
{
    class Program
    {
        static void Main()
        {
            int[] integerValues = { 11, 12, -42, 0, 1, 90, 68, 6, -9 };
            Sort.Quicksort(integerValues);
            Console.WriteLine($"{string.Join(" | ", integerValues)}");

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            Sort.Quicksort(stringValues);
            Console.WriteLine($"{string.Join(" | ", stringValues)}");
        }
    }
}
