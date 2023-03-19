using x4amcd.Player;
using x4amcd.Utils;
using x4amcd.World_Scripts;

namespace x4amcd
{
    public static class Program
    {
        static int TIME = 0;

        readonly static AdamDNA adam = new();

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
            World.WorldVar = WorldCreation.CreateBasicWorld(10, 10);
        }

        public static void AndHeMadeMan()
        {
            World.WorldVar[4][4] = adam;
            adam.SeeWorld();
            adam.RememberWorld();
            PrintHelpers.PrintWorld(adam.CurrentLightMap);
        }

        public static void ThreadProc()
        {
            while (true)
            {
                PrintHelpers.PrintWorld(World.WorldVar);
                PrintHelpers.PrintWorld(adam.GetMask());
                string? x = Console.ReadLine();
                Console.WriteLine($"Read {x}");
                adam.GetMask();
                if (x == "x")
                {
                    Environment.Exit(0);
                }
                TIME++;
            }
        }
    }
}
