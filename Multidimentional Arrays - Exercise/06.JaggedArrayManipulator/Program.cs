using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];

for(int row = 0; row < jagged.Length; row++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    jagged[row] = new int[numbers.Length];

    for(int col  = 0; col < jagged[row].Length; col++)
    {
        jagged[row][col] = numbers[col];
    }
}

for(int row = 0; row < jagged.Length-1; row++)
{
    bool isEqual = false;
    int count = 0;
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        isEqual = true;
    }
    for (int col = 0; col < Math.Min(jagged[row].Length, jagged[row + 1].Length); col++)
    {
        if (isEqual)
        {
            jagged[row][col] *= 2;
            jagged[row + 1][col] *= 2;
        }
        else
        {
            jagged[row][col] /= 2;
            jagged[row + 1][col] /= 2;
            count++;

        }
    }
    if(isEqual)
    {
        continue;
    }
    else
    {
        if (jagged[row].Length > jagged[row + 1].Length)
        {
            for (int j = count; j < jagged[row].Length; j++)
            {
                jagged[row][j] /= 2;
            }
        }
        else
        {
            for (int j = count; j < jagged[row + 1].Length; j++)
            {
                jagged[row + 1][j] /= 2;
            }
        }
    }
    
}

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (input[0] != "End")
{
    string operation = input[0];
    int row = int.Parse(input[1]);
    int col = int.Parse(input[2]);
    int value = int.Parse(input[3]);

    if (!(row >= 0 && col >= 0 && row < jagged.Length && col < jagged[row].Length))
    {
        input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        continue;
    }
    
    if (operation == "Add")
    {
        
        if(row >= 0 && col >= 0 && row < jagged.Length && col < jagged[row].Length)
        {
            jagged[row][col] += value;
        }
    }
    else if(operation == "Subtract")
    {
        jagged[row][col] -= value;
    }
    input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

foreach (int[] row in jagged)
{
    Console.WriteLine(String.Join(" ", row));
}

