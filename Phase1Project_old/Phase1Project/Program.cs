using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Phase1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //var repository = new PipeDelimitedStudentsRepository();
            var repository = new JSONStudentsRepository();
            var students = repository.Load();
            repository.Save(students);



            

            //run(new string[] { "sort" });
            //run(new string[] { "search", "Bleu" });
            //run(new string[] { "load" });
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
                case "load":
                    var things = load();
                    foreach (var thing in things)
                    {
                        Console.WriteLine(thing);
                    }

                    var dict = new Dictionary<int, Thing>(); 
                    foreach (var thing in things)
                    {
                        dict[thing.ID] = thing;
                    }

                    var thing4 = dict[4];
                    Console.WriteLine(thing4);

                    break;
            }
        }

        private static List<Thing> load()
        {
            var things = new List<Thing>();

            var lines = File.ReadAllLines("things1.txt");
            foreach (var line in lines)
            {
                //var fields = line.Split('|');

                //var thing = new Thing(int.Parse(fields[0]), fields[1], fields[2], fields[3], fields[4]);
                var thing = new Thing(line);

                things.Add(thing);
            }

            return things;
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
