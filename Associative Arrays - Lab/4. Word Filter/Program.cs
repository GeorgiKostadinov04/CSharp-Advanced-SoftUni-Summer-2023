

namespace _4._Word_Filter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');

            foreach(string word in words)
            {
                if(word.Length %2 == 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
