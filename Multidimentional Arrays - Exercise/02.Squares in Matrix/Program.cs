using System;
using System.Linq;

int[] matrixParams = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

char[,] matrix = new char[matrixParams[0], matrixParams[1]];

for(int row = 0; row < matrix.GetLength(0); row++)
{
    char[] currRow = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(char.Parse)
    .ToArray();

    for(int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = currRow[col];
    }
}
int count = 0;

for(int row = 0;row < matrix.GetLength(0)-1; row++)
{
    for(int col = 0;col < matrix.GetLength(1) -1; col++)
    {
        char currChar = matrix[row, col];

        if(currChar == matrix[row, col + 1] && currChar == matrix[row+1, col] && currChar == matrix[row+1, col + 1])
        {
            count++;
        }
        
    }
}
Console.WriteLine(count);
