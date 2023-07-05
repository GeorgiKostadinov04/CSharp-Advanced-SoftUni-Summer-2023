using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            command = command.ToLower();

           
            Stack<int> stack = new Stack<int>(numbers);


            while(command != "end")
            {
                string[] cmdArg = command.Split(' ');
                string commandName = cmdArg[0];

                if(commandName == "add")
                {
                    stack.Push(int.Parse(cmdArg[1]));
                    stack.Push(int.Parse(cmdArg[2]));
                }
                else if(commandName == "remove")
                {
                    int numbersToDelete = int.Parse(cmdArg[1]);

                    if(numbersToDelete < stack.Count) 
                    {
                        for (int i = 0; i < numbersToDelete; i++)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        command = Console.ReadLine();
                        command = command.ToLower();
                        continue;
                    }
                    
                }
                command = Console.ReadLine();
                command = command.ToLower();

            }
            int result = 0;

            while(stack.Any())
            {
                result += stack.Pop();
            }

            Console.WriteLine($"Sum: {result}");

        }
    }
}
