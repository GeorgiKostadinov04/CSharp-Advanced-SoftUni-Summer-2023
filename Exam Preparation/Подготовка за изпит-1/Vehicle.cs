namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        private string vin;
        private int mileage;
        private string damage;

        public Vehicle(string vin, int mileage, string damage) 
        {
            VIN = vin;
            Mileage = mileage;
            Damage = damage;
        }
        public string VIN { get => vin; set => vin = value; }

        public int Mileage { get => mileage; set => mileage = value; }

        public string Damage { get => damage; set => damage = value; }

        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }
    }
}
