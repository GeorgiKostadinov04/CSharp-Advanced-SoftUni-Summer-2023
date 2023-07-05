using System;
using System.Collections.Generic;
using System.Linq;

int[] lenght = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int lenghtOne = lenght[0];
int lenghtTwo = lenght[1];

HashSet<int> first = new HashSet<int>();
HashSet<int> second = new HashSet<int>();

for(int i = 0; i < lenghtOne; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!first.Contains(number))
    {
        first.Add(number);
    }
}

for(int i = 0;i < lenghtTwo; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!second.Contains(number))
    {
        second.Add(number);
    }
}

first = first.Intersect(second).ToHashSet();

Console.WriteLine(String.Join(" ", first));
    