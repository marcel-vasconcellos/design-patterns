using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class RectangleAdapter : IRectangle
    {
        ITriangle triangle;
        public RectangleAdapter(ITriangle triangle)
        {
            this.triangle = triangle;
        }
        public void AboutMe()
        {
            triangle.AboutTriangle();
        }
        public double CalculateArea()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
