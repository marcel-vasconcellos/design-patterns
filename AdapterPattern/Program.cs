using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adapter pattern has the objective of converting an interface
            // in order to communicate with another otherwise incompatible interface
            Console.WriteLine("***Adapter Pattern Demo***");
            IRectangle rectangle = new Rectangle(20, 10);
            Console.WriteLine("For initial verification purposes, printing the areas of both shapes.");
            Console.WriteLine("Rectangle area is: {0} Square units.", rectangle.CalculateArea());
            ITriangle triangle = new Triangle(20, 10);
            Console.WriteLine("Triangle area is : {0}", triangle.CalculateAreaOfTriangle());

            Console.WriteLine("Now using adapter.");
            IRectangle adapter = new RectangleAdapter(triangle);
            Console.WriteLine("True fact:");
            adapter.AboutMe();
            Console.WriteLine($"and my area is : {adapter.CalculateArea()} square units.");
            Console.ReadKey();
        }
    }
}