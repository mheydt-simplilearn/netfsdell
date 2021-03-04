using System;
using System.IO;
using System.Linq;

namespace Phase1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //run(new string[] { "sort" });
            run(new string[] { "search", "Bleu" });
        }

        static void run(string[] options)
        {
            foreach (var option in options) Console.WriteLine(option);

            if (options != null && options.Length == 0)
            {
                Console.WriteLine("Sorry, you need to pass at least one option");
                return;
            }

            switch (options[0])
            {
                case "sort": sort(); break;
                case "search":
                    {
                        if (options.Length < 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Searching requires a string to search for...");
                            return;
                        }
                        search(options[1]);
                    }
                    break;
            }
        }

        private static void search(string searchText)
        {
            Console.WriteLine($"Searching for: {searchText}");
            var data = File.ReadAllLines("search.txt");
            var i = 0;
            foreach (var datum in data)
            {
                if (datum.Contains(searchText))
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        private static void sort()
        {
            Console.WriteLine("Now sorting your data");
            var data = File.ReadAllLines("sort.txt");
            Console.WriteLine("Here is the unsorted data:");
            foreach (var datum in data) Console.WriteLine(datum);
            Array.Sort(data);
            Console.WriteLine("Here is your sorted data: ");
            foreach (var datum in data) Console.WriteLine(datum);
        }
    }
}
