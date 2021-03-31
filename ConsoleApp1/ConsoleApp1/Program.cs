using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            (int x, int y, string z) = myfunc();
            Console.WriteLine($"{x} {y} {z}");
        }

        private static (int, int, string) myfunc()
        {
            return (1, 2, "a string");
        }
    }
}
