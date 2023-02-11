using x4amcd.Primordials;
using x4amcd.World_Scripts;

namespace x4amcd
{
    public
    static class Program
    {
        static void Main(string[] args)
        {
            const String name = "x4amcd";
            Console.WriteLine(name);
            Thread t = new(ThreadProc);
            t.Start();

            Program.LetThereBeLight();
            World.PrintWorld();
            while (true)
            {
            }
        }

        public static void LetThereBeLight()
        {
            World.CreateBasicWorld(8, 8);
        }
        public static void ThreadProc()
        {
            var x = Console.ReadLine();
            Console.WriteLine($"Read {x}");
        }

    }
}