using System;
using System.Collections.Generic;


int n = int.Parse(Console.ReadLine());

Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

for(int i = 0; i < n; i++)
{
    int currNum = int.Parse(Console.ReadLine()) ;
    if (!keyValuePairs.ContainsKey(currNum))
    {
        keyValuePairs[currNum] = 1;
    }
    else
    {
        keyValuePairs[currNum]++;
    }
}

foreach(var (key,value) in keyValuePairs)
{
    if (keyValuePairs[key] % 2 == 0)
    {
        Console.WriteLine(key);
    } 
}
