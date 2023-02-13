namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0; 
            int d = 0;
            try
            {
                Console.WriteLine("Ввeди число:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ввeди число:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ввeди число:");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Ввeди число:");
                d = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            Console.WriteLine($"{a} {b} {c} {d}");
        }
    }
}
