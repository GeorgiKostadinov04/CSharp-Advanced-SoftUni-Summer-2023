

namespace _1.Count_Real_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach(int num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;
                }
                counts[num]++;
            }

            foreach(var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
