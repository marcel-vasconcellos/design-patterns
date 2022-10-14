using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Decorator Pattern Demonstration
            Console.WriteLine("***Decorator Pattern Demo***");
            Console.WriteLine("Building home. Adding floor and then painting it.");
            AbstractHome home = new ConcreteHome();
            Console.WriteLine("Current bill breakups are as follows:");
            home.MakeHome();

            // Applying decorator
            // Adding floor
            home = new FloorDecorator(home);
            Console.WriteLine("Floor added. Current bill breakups are as follows:");
            home.MakeHome();

            // Working on top of the previous decorator
            // Painting the home
            home = new PaintDecorator(home);
            Console.WriteLine("\nPaint applied. Current bill breakups are as follows:");
            home.MakeHome();

            Console.ReadKey();
        }
    }
}
