using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x4amcd.Primordials;

namespace x4amcd.Utils
{
    public static class PrintHelpers
    {
        public static readonly String WhiteSpace = " ";
        public static readonly int ThingLength = 3;

        public static void SetColor(int value)
        {
            
            if (value > 5)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public static void ResetColor()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintLightMap(List<List<IThing>> lightMap)
        {
            PrintColNumbers(lightMap);
            PrintRows(lightMap);
        }

        public static void PrintWorld(List<List<IThing>> world)
        {
            PrintColNumbers(world);
            PrintRows(world);
        }

        public static void PrintColNumbers(List<List<IThing>> world)
        {
            Console.Write(
                $"{Environment.NewLine}"
            );
            for (int j = 0; j < PrintHelpers.ThingLength - 2; j++)
            {
                Console.Write(PrintHelpers.WhiteSpace);
            }
            Console.Write("|");
            for (int i = 0; i < world.Count; i++)
            {
                Console.Write(
                    $"{i}"
                );
                for (int j = 0; j < PrintHelpers.ThingLength - 1; j++)
                {
                    Console.Write(PrintHelpers.WhiteSpace);
                }
                if (i < world[i].Count - 1)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
        public static void PrintRows(List<List<IThing>> world)
        {
            int rowNumber = 0;
            foreach (var row in world)
            {
                Console.Write($"{rowNumber++}|");
                foreach (var thing in row)
                {
                    PrintHelpers.SetColor(thing.Value);
                    Console.Write($"{thing}|");
                }
                PrintHelpers.ResetColor();
                Console.WriteLine();
            }
            PrintHelpers.ResetColor();
        }
    }
}