using x4amcd.Primordials;
using x4amcd.Utils;
using x4amcd.World_Scripts;
using x4amcd_Player_Scripts;

namespace x4amcd
{
    public
    static class Program
    {
        static int TIME = 0;
        static void Main(string[] args)
        {
            const String name = "x4amcd";
            Console.WriteLine(name);
            Thread t = new(ThreadProc);
            Program.LetThereBeLight();
            Program.AndHeMadeMan();
            PrintHelpers.ResetColor();
            // And on the seventh day he rested.
            t.Start();


            t.Join();
        }

        public static void LetThereBeLight()
        {
            WorldCreation.CreateBasicWorld(World.WorldVar, 8, 8);
        }

        public static void AndHeMadeMan()
        {
            AdamDNA adam = new();
            World.WorldVar[4][4] = adam;
            adam.SeeWorld();
            PrintHelpers.PrintWorld(adam.CurrentLightMap);
        }
        public static void ThreadProc()
        {

            while (true)
            {
                PrintHelpers.PrintWorld(World.WorldVar);
                string? x = Console.ReadLine();
                Console.WriteLine($"Read {x}");
                if (x == "x")
                {
                    Environment.Exit(0);
                }
                TIME++;
            }


        }

    }
}