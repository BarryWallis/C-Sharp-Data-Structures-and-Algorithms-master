using System;
using System.Globalization;
using System.Linq;

namespace YearlyTransportPlan
{
    class Program
    {
        static void Main()
        {
            TransportType[][] transportTypes = GetTransportTypes();
            WriteTransportPlan(transportTypes);
        }

        private static void WriteTransportPlan(TransportType[][] transportTypes)
        {
            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length) + 2;
            for (int month = 1; month <= transportTypes.Length; month++)
            {
                Console.Write($"{monthNames[month - 1]}:".PadRight(monthNamesPart));
                for (int day = 1; day <= transportTypes[month - 1].Length; day++)
                {
                    ConsoleColor foregroundColor = Console.ForegroundColor;
                    ConsoleColor backgroundColor = Console.BackgroundColor;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = transportTypes[month - 1][day - 1].GetColor();
                    Console.Write(transportTypes[month - 1][day - 1].GetChar());
                    Console.BackgroundColor = backgroundColor;
                    Console.ForegroundColor = foregroundColor;
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        private static string[] GetMonthNames()
        {
            string[] monthNames = new string[12];
            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new(DateTime.Now.Year, month, 1);
                string monthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                monthNames[month-1]  = monthName;
            }

            return monthNames;
        }

        private static TransportType[][] GetTransportTypes()
        {
            Random random = new();
            TransportType[][] transportTypes = new TransportType[12][];
            int transportTypesCount = Enum.GetNames(typeof(TransportType)).Length - 1;
            for (int month = 1; month <= 12; month++)
            {
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
                transportTypes[month - 1] = new TransportType[daysInMonth];
                for (int day = 1; day <= daysInMonth; day++)
                {
                    int randomType = random.Next(transportTypesCount) + 1;
                    transportTypes[month - 1][day - 1] = (TransportType)randomType;
                }
            }

            return transportTypes;
        }
    }
}
