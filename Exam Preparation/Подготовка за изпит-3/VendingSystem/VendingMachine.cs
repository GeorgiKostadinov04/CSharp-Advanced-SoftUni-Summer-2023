using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity) 
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }
        public int ButtonCapacity { get; set; }
        public List<Drink> Drinks { get; set; }
        public int GetCount => Drinks.Count;

        public void AddDrink(Drink drink)
        {
            if(GetCount < ButtonCapacity)
            {
                Drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string name)
        {
            Drink drink = Drinks.FirstOrDefault(x => x.Name == name);
            return Drinks.Remove(drink);
        }

        public Drink GetLongest()
        {
            int longestVolume = int.MinValue;

            foreach(Drink drink in Drinks)
            {
                if(drink.Volume > longestVolume)
                {
                    longestVolume = drink.Volume;
                }
            }

            return Drinks.Where(d=>d.Volume == longestVolume).FirstOrDefault();
        }

        public Drink GetCheapest()
        {
            decimal cheapestPrice = decimal.MaxValue;

            foreach (Drink drink in Drinks)
            {
                if (drink.Price < cheapestPrice)
                {
                    cheapestPrice = drink.Price;
                }
            }

            return Drinks.Where(d => d.Price == cheapestPrice).FirstOrDefault();
        }

        public string BuyDrink(string name)
        {
            Drink drink = Drinks.FirstOrDefault(d=>d.Name == name);

            return drink.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Drinks available:");

            foreach(Drink drink in Drinks)
            {
                sb.AppendLine(drink.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
