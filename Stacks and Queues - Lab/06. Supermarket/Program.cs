using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();

            while(input != "End")
            {
                if(input != "Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    while (names.Any())
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                    
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
