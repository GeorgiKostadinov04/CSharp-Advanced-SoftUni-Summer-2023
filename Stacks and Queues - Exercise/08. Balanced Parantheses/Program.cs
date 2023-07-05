using System;
using System.Collections.Generic;


string input = Console.ReadLine();

Stack<char> stack = new Stack<char>();


foreach(char c in input)
{
    if(c == '(' || c=='{' || c =='[')
    {
        stack.Push(c);
    }
    else if(c == ')')
    {
        if(stack.Count == 0 || stack.Pop() != '(')
        {
            Console.WriteLine("NO");
            return;
        }
    }
    else if(c == '}')
    {
        if (stack.Count == 0 || stack.Pop() != '{')
        {
            Console.WriteLine("NO");
            return;
        }
    }
    else if (c == ']')
    {
        if (stack.Count == 0 || stack.Pop() != '[')
        {
            Console.WriteLine("NO");
            return;
        }
    }

}
if(stack.Count > 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}

