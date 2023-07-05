using System;
using System.Collections.Generic;
using System.Linq;

int numberOfCommands = int.Parse(Console.ReadLine());

Stack<int> stack = new();

for(int i = 0; i < numberOfCommands; i++)
{
    int[] commandArgs = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();
    int commandType = commandArgs[0];
    
    switch (commandType)
    {
        case 1:
            int numberToPush = commandArgs[1];
            stack.Push(numberToPush);

            break;
        case 2:
            stack.Pop();
            
            break;
        case 3:
            if (stack.Any())
            {
                Console.WriteLine(stack.Max());
            }

            break;
        case 4:
            if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }

            break;
    }
    
}

Console.WriteLine(string.Join(", ",stack));
