using System;
using System.Collections.Generic;
using System.Linq;

int quantityOfFood = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new(orders);

Console.WriteLine(queue.Max());

while(queue.Any() && quantityOfFood > 0)
{
    if(quantityOfFood - queue.Peek() >= 0)
    {
        quantityOfFood -= queue.Peek();
        queue.Dequeue();
    }
    else
    {
        Console.Write("Orders left: ");
        Console.WriteLine(string.Join(" ", queue));
        return;
    }
}

if (!queue.Any())
{
    if(quantityOfFood >= 0)
    {
        Console.WriteLine("Orders complete");
    }
}

