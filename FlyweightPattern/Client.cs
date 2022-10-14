using System;

namespace FlyweightPattern
{
    internal class Client
    {
        /* Main purpose of Flyweight pattern is to be a reusable object in many contexts at the same time.
         * Similar to a Singleton pattern. */
        static void Main(string[] args)
        {
            Console.WriteLine("***Flyweight Pattern Demo");
            VehicleFactory vehicleFactory = new VehicleFactory();
            IVehicle vehicle;

            for (int i = 0; i < 3; i++)
            {
                vehicle = vehicleFactory.GetVehicleFromVehicleFactory("car");
                vehicle.AboutMe(GetRandomColor());
            }

            int numOfDistinctVehicles = vehicleFactory.TotalObjectsCreated();

            Console.WriteLine($"Now the number of distinct vehicles is {numOfDistinctVehicles}");

            for (int i = 0; i < 5; i++)
            {
                vehicle = vehicleFactory.GetVehicleFromVehicleFactory("bus");
                vehicle.AboutMe(GetRandomColor());
            }

            numOfDistinctVehicles = vehicleFactory.TotalObjectsCreated();

            Console.WriteLine($"Now the number of distinct vehicles is {numOfDistinctVehicles}");

            for (int i = 0; i < 2; i++)
            {
                vehicle = vehicleFactory.GetVehicleFromVehicleFactory("motorcycle");
                vehicle.AboutMe(GetRandomColor());
            }

            numOfDistinctVehicles = vehicleFactory.TotalObjectsCreated();

            Console.WriteLine($"Now the number of distinct vehicles is {numOfDistinctVehicles}");

            Console.ReadKey();
        }

        private static string GetRandomColor()
        {
            Random r = new Random();

            int random = r.Next(100);
            if(random % 2 == 0)
            {
                return "red";
            }
            else
            {
                return "green";
            }
        }
    }
}
