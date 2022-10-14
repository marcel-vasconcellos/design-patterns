using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class Car : IVehicle
    {
        private string description;

        public Car(string description)
        {
            this.description = description;
        }

        // Client will supply the color
        public void AboutMe(string color)
        {
            Console.WriteLine($"{description} with {color} color");
        }
    }
}
