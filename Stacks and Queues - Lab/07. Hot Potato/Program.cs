﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            Queue<string> queue = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());

            while (queue.Count >1)
            {
                for(int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
