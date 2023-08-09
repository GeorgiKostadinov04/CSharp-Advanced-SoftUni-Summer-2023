using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        private string name;
        private int capacity;
        private List<Child> registry;

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            registry = new List<Child>();
        }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public List<Child> Registry => registry;
        public int ChildrenCount => this.Registry.Count;

        public bool AddChild(Child child)
        {
            if(Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] names = childFullName.Split(" ");
            string firstName = names[0];
            string lastName = names[1];
            Child childToRemove = Registry.FirstOrDefault(c=> c.FirstName == firstName && c.LastName == lastName);
            return Registry.Remove(childToRemove);
        }

        public Child GetChild(string childFullName)
        {
            string[] names = childFullName.Split(" ");
            string firstName = names[0];
            string lastName = names[1];

            return Registry.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Registered children in {Name}:");

            foreach(Child child in Registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName))
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
