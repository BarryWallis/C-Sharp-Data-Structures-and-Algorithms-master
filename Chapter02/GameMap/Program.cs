using System;
using System.Text;

namespace GameMap
{
    internal class Program
    {
        private static void Main()
        {
            TerrainType[,] map = GetMap();
            Console.OutputEncoding = UTF8Encoding.UTF8;
            ConsoleColor originalConsoleColor = Console.ForegroundColor;
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    Console.ForegroundColor = map[row, column].GetColor();
                    Console.Write(map[row, column].GetChar());
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = originalConsoleColor;
        }

        private static TerrainType[,] GetMap()
        {
            TerrainType[,] map =
            {
                {
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Grass,
                    TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass,
                },
                {
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Grass,
                    TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass,
                },
                {
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Grass,
                    TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass,
                },
                {
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Grass,
                    TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass, TerrainType.Grass,
                },
                {
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand,
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Wall, TerrainType.Wall, TerrainType.Wall,
                },
                {
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand,
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Wall, TerrainType.Sand, TerrainType.Sand,
                },
                {
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand, TerrainType.Sand,
                    TerrainType.Sand, TerrainType.Sand, TerrainType.Wall, TerrainType.Sand, TerrainType.Sand,
                },
                {
                    TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water,
                    TerrainType.Water, TerrainType.Water, TerrainType.Wall, TerrainType.Sand, TerrainType.Sand,
                },
                {
                    TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water,
                    TerrainType.Water, TerrainType.Water, TerrainType.Wall, TerrainType.Sand, TerrainType.Sand,
                },
                {
                    TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water,
                    TerrainType.Water, TerrainType.Water, TerrainType.Wall, TerrainType.Water, TerrainType.Water,
                },
                {
                    TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water,
                    TerrainType.Water, TerrainType.Water, TerrainType.Wall, TerrainType.Water, TerrainType.Water,
                },
            };

            return map;
        }
    }
}
