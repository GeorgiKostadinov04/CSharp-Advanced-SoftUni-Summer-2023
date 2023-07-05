using System;
using System.Linq;

int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = tokens[0];
int cols = tokens[1];

string[,] matrix = new string[rows, cols];

for(int row =  0; row < rows; row++)
{
    string[] currRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    for(int col = 0; col < cols; col++)
    {
        matrix[row,col] = currRow[col];
    }
}

string[] command = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
while (command[0] != "END")
{

    if (command.Length != 5 || command[0] != "swap")
    {
        Console.WriteLine("Invalid input!");
        command = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        continue;
    }
    int firstRow = int.Parse(command[1]);
    int firstCol = int.Parse(command[2]);
    int secondRow = int.Parse(command[3]);
    int secondCol = int.Parse(command[4]);
    
    if (firstRow < 0 || firstRow >= rows || firstCol < 0
        || firstCol >= cols || secondRow < 0 || secondRow >= rows
        || secondCol < 0 || secondCol >= cols)
    {
        Console.WriteLine("Invalid input!");
        command = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        continue;
    }

    string temp = matrix[firstRow, firstCol];
    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
    matrix[secondRow, secondCol] = temp;

    for(int row = 0; row < rows; row++)
    {
        for(int col = 0; col < cols; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
    command = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

}