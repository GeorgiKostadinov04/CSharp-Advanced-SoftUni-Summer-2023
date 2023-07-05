using System;
using System.Collections.Generic;
using System.Linq;


int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size,size];


for(int row = 0; row < size; row++)
{
    int[] numbersInCol = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();
    for(int col = 0; col < size; col++)
    {
        matrix[row, col] = numbersInCol[col];
    }
}
int firstSum = 0;
int secondSum = 0;

for(int row = 0; row < size; row++)
{
    for(int col = 0; col < size; col++)
    {
        if(row == col)
        {
            firstSum += matrix[row, col];
        }
    }
}

for(int i = 0; i < size; i++)
{
    secondSum += matrix[size-1-i,i];
}

Console.WriteLine(Math.Abs(firstSum-secondSum));


