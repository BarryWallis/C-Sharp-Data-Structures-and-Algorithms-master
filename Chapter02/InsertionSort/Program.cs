﻿using System;

using SortLib;

namespace InsertionSort
{
    internal class Program
    {
        private static void Main()
        {
            int[] integerValues = { 11, 12, -42, 0, 1, 90, 68, 6, -9 };
            Sort.InsertionSort(integerValues);
            Console.WriteLine($"{string.Join(" | ", integerValues)}");

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            Sort.InsertionSort(stringValues);
            Console.WriteLine($"{string.Join(" | ", stringValues)}");
        }
    }
}
