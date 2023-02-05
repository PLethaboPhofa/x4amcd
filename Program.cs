namespace x4amcd
{
    class Program
    {

        
        static List<List<string>> world = new List<List<string>>();
        static void Main(string[] args)
        {
            String name = "x4amcd";
            Console.WriteLine($"{name}");
            Thread t = new Thread(ThreadProc);
            t.Start(Program.world);

            t.Join();
            Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
            Console.ReadLine();
        }

        public static void ThreadProc(object? world)
        {
            var clean = (List<List<string>>) (world==null?new List<List<string>>():world);
                
            for (int i = 0; i < 10; i++)
            {
                var x = Console.ReadLine();
                Console.WriteLine($"Read {x}");
                clean.Add(new List<string>());
                clean[i].Add(x==null?"":x);
                Program.printWorld(clean);
            }
        }

        public static void printWorld(List<List<string>> world)
        {
            
            foreach (var row in world)
            {
                foreach (var cell in row)
                {
                    Console.Write(cell);
                }
                Console.WriteLine();
            }
        }

    }
}