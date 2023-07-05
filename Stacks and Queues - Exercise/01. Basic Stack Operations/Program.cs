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


int numbersToPop = input[1];
int magicNum = input[2];

Stack<int> stack = new(numbers);

for(int i = 0; i < numbersToPop; i++)
{
    stack.Pop();
}

if (stack.Contains(magicNum))
{
    Console.WriteLine("true");
}
else if (!stack.Any())
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(stack.Min());
}
