using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // This is the Flyweight factory
    internal class VehicleFactory
    {
        private Dictionary<string, IVehicle> vehicles = new Dictionary<string, IVehicle>();
        public int TotalObjectsCreated()
        {
            return vehicles.Count;
        }

        public IVehicle GetVehicleFromVehicleFactory(string vehicleType)
        {
            IVehicle vehicleCategory = null;
            if (vehicles.ContainsKey(vehicleType))
            {
                vehicleCategory = vehicles[vehicleType];
            }
            else
            {
                switch (vehicleType)
                {
                    case "car":
                        vehicleCategory = new Car("One car is created");
                        vehicles.Add("car", vehicleCategory);
                        break;

                    case "bus":
                        vehicleCategory = new Bus("One car is created");
                        vehicles.Add("bus", vehicleCategory);
                        break;

                    case "motorcycle":
                        vehicleCategory = new Motorcycle("One car is created");
                        vehicles.Add("motorcycle", vehicleCategory);
                        break;

                    default:
                        throw new Exception("Vehicle Factory can give you cars and buses only.");

                }
            }
            return vehicleCategory;
        }
    }
}
