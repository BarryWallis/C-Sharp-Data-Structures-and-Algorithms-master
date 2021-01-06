using System;

namespace GameMap
{
    public static class TerrainTypeExtensions
    {
        public static ConsoleColor GetColor(this TerrainType terrain) => terrain switch
        {
            TerrainType.Grass => ConsoleColor.Green,
            TerrainType.Sand => ConsoleColor.Yellow,
            TerrainType.Water => ConsoleColor.Blue,
            TerrainType.Wall => ConsoleColor.DarkGray,
            _ => throw new ArgumentException($"Unexpected TerrainEnum value: {terrain}.", nameof(terrain))
        };

        public static char GetChar(this TerrainType terrain) => terrain switch
        {
            TerrainType.Grass => '\u201c',
            TerrainType.Sand => '\u25cb',
            TerrainType.Water => '\u2248',
            TerrainType.Wall => '\u25cf',
            _ => throw new ArgumentException($"Unexpected TerrainEnum value: {terrain}.", nameof(terrain))
        };
    }
}
