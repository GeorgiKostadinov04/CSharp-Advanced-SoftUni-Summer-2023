using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Stack<string> stack = new Stack<string>(input.Reverse());
            int result = int.Parse(stack.Pop());

            while(stack.Any())
            {
                char operation = char.Parse(stack.Pop());
                int number = int.Parse(stack.Pop());
                
                if(operation == '+')
                {
                    result += number;
                }
                else if(operation == '-') 
                {
                    result -= number;
                }

            }
            Console.WriteLine(result);
        }
    }
}
