using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CarBody
    {
        string carType;
        static int carCount = 0;

        public CarBody(string carType)
        {
            this.carType = carType;
        }

        public void MakeCarBody()
        {
            Console.WriteLine($"Constructing one {carType} car.");
            Console.WriteLine("Car production finished.");
            Console.WriteLine($"Total number of cars created at this moment = {++carCount}");
        }

        public void DestroyCarBody()
        {
            if(carCount > 0)
            {
                --carCount;
                Console.WriteLine("Car's desctruction process is over");
            }
            else
            {
                Console.WriteLine("All cars are destroyed");
                Console.WriteLine("Color removar operation will not continue");
            }
        }
    }
}
