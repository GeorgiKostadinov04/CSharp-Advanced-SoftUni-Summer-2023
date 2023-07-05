using System;
using System.Linq;

int[] matrixParams = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixParams[0];
int cols = matrixParams[1];

char[,] matrix = new char[rows, cols];

string input = Console.ReadLine();

int index = 0;


for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            if (input.Length == index)
            {
                index = 0;
            }
            matrix[row, col] = input[index];
            index++;

        }
    }
    else
    {
        for (int col = 0; col < cols; col++)
        {
            if (input.Length == index)
            {
                index = 0;
            }
            matrix[row, cols - 1 - col] = input[index];
            index++;
        }
    }
    ;
}


for (int row = 0; row < rows; row++)
{
    for(int col = 0; col < cols; col++)
    {
        Console.Write($"{matrix[row, col]}");
    }
    Console.WriteLine();
}
