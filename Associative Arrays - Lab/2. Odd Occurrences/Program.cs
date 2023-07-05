
namespace _2._Odd_Occurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
            }

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach(string word in words)
            {
                if (!count.ContainsKey(word))
                {
                    count[word] = 0;
                }
                count[word]++;
            }

            List<string> wordsToPrint = new List<string>();

            foreach (var item in count)
            {
                if(item.Value %2 != 0)
                {
                    wordsToPrint.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(" ", wordsToPrint));
        }
    }
}
