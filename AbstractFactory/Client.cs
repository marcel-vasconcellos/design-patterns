using System;

namespace AbstractFactory
{
    internal class Client
    {
        static void Main(string[] args)
        {
            /* Abstract factory pattern is basically a wrapper around the constructor of an object.
             * It differs from the other factories by having the factory provider, which will distribute the 
             * specific type of factory needed, providing even more abstraction for the building process. */
            Console.WriteLine("***Abstract Factory Pattern Demo***");
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog dog = animalFactory.GetDog();
            ICat cat = animalFactory.GetCat();
            dog.AboutMe();
            cat.AboutMe();
            Console.WriteLine("*************");
            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            dog = animalFactory.GetDog();
            cat = animalFactory.GetCat();
            dog.AboutMe();
            cat.AboutMe();
            Console.ReadKey();
        }
    }
}
