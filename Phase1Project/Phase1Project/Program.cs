using System;
using System.IO;

namespace Phase1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //run(new string[] { "sort" }); 
            run(new string[] { "search" });
        }

        static void run(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Must specify an action");
                return;
            }

            switch (args[0])
            {
                case "sort":
                    {
                        sort();
                    }
                    break;

                case "search":
                    {
                        search();
                    }
                    break;
            }
        }

        static void sort()
        {
            Console.WriteLine("Sorting....");

            var data = File.ReadAllLines("sort.txt");
            Array.Sort(data);
            Console.WriteLine("Here is the sorted data...");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        static void search()
        {
            Console.WriteLine("Searching....");

            var data = File.ReadAllLines("search.txt");
            
            Console.WriteLine("Search results...");
            foreach (var item in data)
            {
                if (item.Contains("Bra"))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
