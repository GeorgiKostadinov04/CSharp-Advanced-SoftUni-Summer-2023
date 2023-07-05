using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
HashSet<string> chemicalElements = new HashSet<string>();

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    for(int j = 0; j < input.Length; j++)
    {
        if (!chemicalElements.Contains(input[j]))
        {
            chemicalElements.Add(input[j]);
        }
    }
}

Console.WriteLine(String.Join(" ", chemicalElements.OrderBy(x => x)));
