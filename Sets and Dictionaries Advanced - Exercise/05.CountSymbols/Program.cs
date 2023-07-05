using System.Linq;

string input = Console.ReadLine();

SortedDictionary<char,int> keyValuePairs = new SortedDictionary<char,int>();

foreach(char ch in input)
{
    if (!keyValuePairs.ContainsKey(ch))
    {
        keyValuePairs[ch] = 1;
    }
    else
    {
        keyValuePairs[ch]++;
    }
}

foreach(var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}
