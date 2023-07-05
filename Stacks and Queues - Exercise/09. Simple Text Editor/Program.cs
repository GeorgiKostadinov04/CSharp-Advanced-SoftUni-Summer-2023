using System;
using System.Collections.Generic;
using System.Text;

int numberOfOperations = int.Parse(Console.ReadLine());
string text = string.Empty;

Stack<string> stack = new();

for(int i = 0; i < numberOfOperations; i++)
{
    string[] cmdArgs = Console.ReadLine().Split(' ');
    int operation = int.Parse(cmdArgs[0]);

    if(operation == 1)
    {
        string textToAdd = cmdArgs[1];
        text += textToAdd;
        stack.Push(text);
    }
    else if(operation == 2)
    {
        int count = int.Parse(cmdArgs[1]);

        if(text.Length >= count)
        {
            text = text.Remove(text.Length-count, count); ;
        }
        stack.Push(text);
    }
    else if( operation == 3)
    {
        int index = int.Parse(cmdArgs[1]);
        if(index > 0 &&  text.Length >= index) 
        {
            Console.WriteLine(text[index-1]);
        }
        
    }
    else if(operation == 4)
    {
        if(stack.Count > 0)
        {
            stack.Pop();
            if(stack.Count > 0)
            {
                text = stack.Peek();
            }
            else
            {
                text = string.Empty;
            }
        }
        else
        {
            text = string.Empty;
        }
    }
}
