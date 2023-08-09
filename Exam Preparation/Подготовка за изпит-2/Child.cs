namespace SoftUniKindergarten
{
    public class Child
    {
        private string firstName;
        private string lastName;
        private int age;
        private string parentName;
        private string contactNumber;

        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ParentName = parentName;
            ContactNumber = contactNumber;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string ParentName { get => parentName; set => parentName = value; }

        public string ContactNumber { get => contactNumber; set => contactNumber = value; }

        public override string ToString()
        {
            return $"Child: {FirstName} {LastName}, Age: {Age}, Contact info: {ParentName} - {ContactNumber}";
        }
    }
}
