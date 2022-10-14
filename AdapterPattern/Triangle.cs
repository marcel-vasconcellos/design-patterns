using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Triangle : ITriangle
    {
        double baseLength;
        double height;
        public Triangle(double length, double height)
        {
            this.baseLength = length;
            this.height = height;
        }
        public double CalculateAreaOfTriangle()
        {
            return 0.5 * baseLength * height;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("Actually, I am a triangle.");
        }
    }
}
