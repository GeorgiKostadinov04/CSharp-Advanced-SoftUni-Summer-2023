using System;
using System.Collections.Generic;
using System.Linq;

int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new(numbers);

int numsToDequeue = input[1];
int magicNum = input[2];

for(int i = 0; i < numsToDequeue; i++)
{
    queue.Dequeue();
}

if (queue.Contains(magicNum))
{
    Console.WriteLine("true");
}
else
{
    if (!queue.Any())
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(queue.Min());
    }
}

