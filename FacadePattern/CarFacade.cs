using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CarFacade
    {
        /* Objective of facade pattern is to gather in one class all the methods
         * involved in a creation process. Thus making it simpler for the cliend. */
        CarBody carBody;
        CarColor carColor;

        public CarFacade(string carType, string color = "steel")
        {
            carBody = new CarBody(carType);
            carColor = new CarColor(color);
        }

        public void ConstructCar()
        {
            Console.WriteLine("Car creation through facade starts...");
            carBody.MakeCarBody();
            carColor.SetColor();
            Console.WriteLine();
        }

        public void DestroyCar()
        {
            Console.WriteLine("Making an attempt to destroy one car using facade now.");
            carColor.RemoveColor();
            carBody.DestroyCarBody();
            Console.WriteLine();
        }
    }
}
