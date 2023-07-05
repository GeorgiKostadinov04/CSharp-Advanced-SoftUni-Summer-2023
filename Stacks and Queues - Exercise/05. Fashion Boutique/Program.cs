using System;
using System.Collections.Generic;
using System.Linq;

int[] clothes = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new(clothes);

int rackCapacity = int.Parse(Console.ReadLine());
int currRack = rackCapacity;
int rackCount = 0;

while (stack.Any())
{
    if(currRack - stack.Peek() > 0)
    {
        currRack -= stack.Pop();
    }
    else if(currRack - stack.Peek() == 0)
    {
        currRack -= stack.Pop();
        rackCount++;
        if (!stack.Any())
        {
            Console.WriteLine(rackCount);
            return;
        }
        else
        {
            currRack = rackCapacity;
        }
    }
    else if(currRack - stack.Peek() < 0)
    {
        rackCount++;
        currRack = rackCapacity;
        currRack -= stack.Pop();

    }
}

if(currRack > 0)
{
    rackCount++;
}

Console.WriteLine(rackCount);