namespace x4amcd
{
    class Program
    {
        static async void Main(string[] args)
        {
            String name = "x4amcd";
            Console.WriteLine($"Hello, World! My name is {name}.");
            Console.ReadKey(true);
            using (var stream = Console.OpenStandardInput())
            {
                var buffer = new byte[1];
                var bytesRead = await stream.ReadAsync(buffer, 0, 1);
                char c = (char)buffer[0];
                Console.WriteLine(c);
            }
        }
    }
}