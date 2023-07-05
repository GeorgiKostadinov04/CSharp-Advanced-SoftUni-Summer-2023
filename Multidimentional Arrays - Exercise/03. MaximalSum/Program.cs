using System;
using System.Linq;

int[] matrixParams = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[,] matrix = new int[matrixParams[0], matrixParams[1]];

for(int row = 0; row < matrix.GetLength(0); row++)
{
    int[] currRow = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for(int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = currRow[col];
    }
}
int biggestSum = int.MinValue;
int maxSumRow = 0;
int maxSumColumn = 0;


for(int row = 0; row < matrixParams[0] - 2; row++)
{

    for (int col = 0; col < matrixParams[1] - 2; col++)
    {
        int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        if(currSum > biggestSum)
        {
            biggestSum = currSum;
            maxSumRow = row;
            maxSumColumn = col;
        }
    }
}
Console.WriteLine($"Sum = {biggestSum}");

for(int row = maxSumRow; row < maxSumRow + 3; row++)
{
    for(int col = maxSumColumn; col < maxSumColumn + 3; col++)
    {
        Console.Write($"{matrix[row,col]} ");
    }

    Console.WriteLine();
}
