using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(numbers);
            List<int> list = new List<int>();
            
            while(queue.Any())
            {
                if(queue.Peek() % 2 == 0)
                {
                    list.Add(queue.Dequeue());
                }
                else if(queue.Peek() % 2 == 1)
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", list));


        }
    }
}
