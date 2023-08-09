using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        private List<Vehicle> vehicles;
        private int capacity;

        public RepairShop(int capacity)
        {
            Capacity = capacity;
            vehicles = new List<Vehicle>();
        }
        public int Capacity { get => capacity; set => capacity = value; }

        public List<Vehicle> Vehicles => vehicles;

        public void AddVehicle(Vehicle vehicle)
        {
            if(Vehicles.Count < Capacity) 
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            return Vehicles.Remove(Vehicles.FirstOrDefault(v=>v.VIN == vin));
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            return this.Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();

        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vehicles in the preparatory:");

            foreach(Vehicle vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
