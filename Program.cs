namespace x4amcd
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "x4amcd";
            Console.WriteLine($"{name}");
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();

            t.Join();
            Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
            Console.ReadLine();
        }

        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                var x = Console.ReadLine();
                Console.WriteLine($"Read {x}");
            }
        }

    }
}