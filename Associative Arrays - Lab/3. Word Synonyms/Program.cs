

namespace _3._Word_Synonyms
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> wordsWithSynonyms = new Dictionary<string,List<string>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (!wordsWithSynonyms.ContainsKey(word))
                {
                    wordsWithSynonyms.Add(word, new List<string>());
                    wordsWithSynonyms[word].Add(synonyms);
                }
                else
                {
                    wordsWithSynonyms[word].Add(synonyms);
                }
            }

            foreach(var item in wordsWithSynonyms)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
            }
        }
    }
}
