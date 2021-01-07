using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearlyTransportPlan
{
    public static class TransportTypeExtensions
    {
        public static char GetChar(this TransportType transportType) => transportType switch
        {
            TransportType.Bike => 'B',
            TransportType.Bus => 'U',
            TransportType.Car => 'C',
            TransportType.Subway => 'S',
            TransportType.Walk => 'W',
            _ => throw new ArgumentException($"Unknown TransportType: {transportType}", nameof(transportType))
        };

        public static ConsoleColor GetColor(this TransportType transportType) => transportType switch
        {
            TransportType.Bike => ConsoleColor.Blue,
            TransportType.Bus => ConsoleColor.DarkGreen,
            TransportType.Car => ConsoleColor.Red,
            TransportType.Subway => ConsoleColor.DarkMagenta,
            TransportType.Walk => ConsoleColor.DarkYellow,
            _ => throw new ArgumentException($"Unknown TransportType: {transportType}", nameof(transportType))
        };

    }
}
