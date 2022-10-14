using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class Bus : IVehicle
    {
        private string description;

        public Bus(string description)
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
