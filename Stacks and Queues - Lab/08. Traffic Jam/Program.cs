using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsThatCanPassAtOnce = int.Parse(Console.ReadLine());
            string command = string.Empty;
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while((command = Console.ReadLine()) != "end")
            {
                if(command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    int copy = numberOfCarsThatCanPassAtOnce;
                    while(copy > 0 && cars.Any())
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        copy--;
                        counter++;
                    }
                }
                
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
