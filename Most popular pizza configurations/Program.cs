using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static System.Console;
using static System.ConsoleColor;

namespace Most_popular_pizza_configurations
{
    class Program
    {
        public static void Main(string[] args)
        {
            int listNumber = 1;

            JsonConvert
                .DeserializeObject<List<Pizza>>(
                    File.ReadAllText(@"..\..\pizzas.json"))
                .CountPizzas()
                .OrderByDescending(p => p.Count)
                .Take(10)
                .ToList()
                .ForEach(i =>
                {
                    ForegroundColor = White;
                    Write($"№{listNumber++}. ");
                    ForegroundColor = Green;
                    Write("Pizza where number of orders is ");
                    ForegroundColor = White;
                    WriteLine($"{ i.Count}.");
                    ForegroundColor = DarkMagenta;
                    WriteLine("Toppings:");
                    i.Pizza.toppings.ForEach(t =>
                    {
                        ForegroundColor = White;
                        WriteLine($"\t{t}");
                    });
                    WriteLine();
                });

            ReadKey();
        }
    }
}
