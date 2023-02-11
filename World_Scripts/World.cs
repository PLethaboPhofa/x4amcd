using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x4amcd.Exceptions;
using x4amcd.Objects;
using x4amcd.Primordials;
using x4amcd.Utils;

namespace x4amcd.World_Scripts
{
    public static class World
    {
        private static readonly List<List<IThing>> world = new();

        public static List<List<IThing>> GetLightMap(Tuple<int, int> position, int visualAcutity)
        {
            List<List<IThing>> lightMap = new();
            for (int i = 0; i < visualAcutity; i++)
            {
                lightMap.Add(new List<IThing>());
                for (int j = 0; j < visualAcutity; j++)
                {
                    lightMap[i].Add(
                        world[position.Item1 + i][position.Item2 + j]
                    );
                }
            }
            return lightMap;
        }

        public static Tuple<int, int> GetPosition(IThing thing)
        {
            int column = -1;
            int row = world.FindIndex((row) =>
            {
                column = row.IndexOf(thing);
                return column != -1;
            });
            return column == -1 ?
                throw new EThingNotFound() :
                new Tuple<int, int>(row, column);
        }

        public static void PrintWorld()
        {
            Console.Write(
                $"{Environment.NewLine}{PrintHelpers.WhiteSpace}|"
            );
            for (int i = 0; i < world.Count; i++)
            {
                Console.Write(
                    i == world[i].Count - 1 ?
                    $"{i}|{Environment.NewLine}" :
                    $"{i}|"
                );
            }

            int rowNumber = 0;
            foreach (var row in world)
            {
                Console.Write($"{rowNumber++}|");
                foreach (var thing in row)
                {
                    Console.Write($"x|");
                }
                Console.WriteLine();
            }
        }

        public static void CreateBasicWorld(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                world.Add(new List<IThing>());
                for (int j = 0; j < columns; j++)
                {
                    world[i].Add(new Rock());
                }
            }
        }
    }
}