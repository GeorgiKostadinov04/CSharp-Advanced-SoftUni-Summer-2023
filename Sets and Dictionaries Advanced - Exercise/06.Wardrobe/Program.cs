using System;
using System.Collections.Generic;



int n = int.Parse(Console.ReadLine());
Dictionary<string,Dictionary<string, int>> colorClothers = new();

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(new string[] {" -> ",","}, StringSplitOptions.RemoveEmptyEntries);

    string color = input[0];

    if (!colorClothers.ContainsKey(color))
    {
        colorClothers[color] = new Dictionary<string, int>();
        
    }
    for (int j = 1; j < input.Length; j++)
    {
        if (!colorClothers[color].ContainsKey(input[j]))
        {
            colorClothers[color].Add(input[j], 1);
        }
        else
        {
            colorClothers[color][input[j]]++;
        }

    }

}

string[] outputInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string wantedColor = outputInfo[0];
string wantedCloth = outputInfo[1];

foreach(var item in colorClothers)
{
    Console.WriteLine($"{item.Key} clothes:");
    foreach(var current in item.Value)
    {
        if (item.Key == wantedColor && current.Key == wantedCloth)
        {
            Console.WriteLine($"* {current.Key} - {current.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {current.Key} - {current.Value}");
        }
    }
    
}
