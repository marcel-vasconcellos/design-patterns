using System;

namespace SimpleFactoryPattern
{
    public class Client
    {
        static void Main(string[] args)
        {
            // Simple factory pattern is basically a wrapper around the constructor of an object
            Console.WriteLine("Simple Factory Pattern demonstration!");
            IAnimal preferredAnimal = null;
            SimpleFactory simpleFactory = new SimpleFactory();
            preferredAnimal = simpleFactory.CreateAnimal();
            preferredAnimal.AboutMe();
            Console.ReadKey();
        }
    }
}
