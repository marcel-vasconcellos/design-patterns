using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CarColor
    {
        string color;
        public CarColor(string color)
        {
            this.color = color;
        }

        public void SetColor()
        {
            if(color == "steel")
            {
                Console.WriteLine($"The default color {color} is set for the car.");
            }
            else
            {
                Console.WriteLine($"Painting the car with your favorite color.");
            }
        }

        public void RemoveColor()
        {
            Console.WriteLine("Attempting to remove the colors from the car");
        }
    }
}
