using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;

        }
        public Person(int age) 
            : this()
        {
            this.Age = age;
        }

        public Person(string nameValue, int age) 
            : this(age)
        {
            this.Name = nameValue;
        }

        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.Age;
            }
            set
            {
                this.Age = value;
            }
        }
    }
}
