using System;

namespace FacadePattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            /* Objective of facade pattern is to gather in one Facade class all the methods
             * involved in a creation process. Thus making it simpler for the client. */
            Console.WriteLine("***Facade Pattern Demo***");
            // Making a black Mustang car
            CarFacade facade = new CarFacade("Mustang", "black");
            facade.ConstructCar();
            // Making a regular Civic
            facade = new CarFacade("Civic");
            facade.ConstructCar();
            // Destroying one car
            facade.DestroyCar();
            // Destroying another car
            facade.DestroyCar();
            // This attempt to destruct will fail
            facade.DestroyCar();
            Console.ReadLine();

        }
    }
}
