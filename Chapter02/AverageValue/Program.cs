using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageValue
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = new();

            while (GotANumber(out double number))
            {
                numbers.Add(number);
                Console.WriteLine($"The average value is {numbers.Average()}");
            }
        }

        private static bool GotANumber(out double number)
        {
            Console.Write($"Enter a number: ");
            string? numberString = Console.ReadLine();
            return double.TryParse(numberString, out number);
        }
    }
}
