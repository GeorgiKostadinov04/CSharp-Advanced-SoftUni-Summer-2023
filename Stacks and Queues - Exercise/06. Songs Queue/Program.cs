using System;
using System.Collections.Generic;
using System.Linq;


string[] songs = Console.ReadLine().Split(", ");

Queue<string> queue = new Queue<string>(songs);

while (queue.Any())
{
    string[] commArgs = Console.ReadLine().Split(" ");

    string commandType = commArgs[0].ToLower();

    if(commandType == "play")
    {
        queue.Dequeue();
    }
    else if(commandType == "add")
    {
        string currSong = string.Join(" ", commArgs.Skip(1));

        if(queue.Contains(currSong))
        {
            Console.WriteLine($"{currSong} is already contained!");
            continue;
        }
        queue.Enqueue(currSong);
    }
    else if(commandType == "show")
    {
        Console.WriteLine(string.Join(", ", queue));
    }

}

Console.WriteLine("No more songs!");
