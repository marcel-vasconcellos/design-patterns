using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Rectangle : IRectangle
    {
        double length;
        public double width;
        public Rectangle(double length, double width)
        {
            this.length = length;   
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public void AboutMe()
        {
            Console.WriteLine("Actually, I am a rectangle.");
        }
    }
}
