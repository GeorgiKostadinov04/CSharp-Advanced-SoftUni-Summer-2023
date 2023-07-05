using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "No name";
            age = 1;

        }
        public Person(int value)
        {
            name = "No name";
            age = value;
        }

        public Person(string nameValue, int ageValue)
        {
            name = nameValue;
            age = ageValue;
        }
    }
}
