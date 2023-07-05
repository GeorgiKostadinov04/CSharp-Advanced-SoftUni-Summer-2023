using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

           foreach(char ch in input)
            {
                stack.Push(ch);
            }

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
