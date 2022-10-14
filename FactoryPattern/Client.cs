using System;

namespace FactoryPattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            /* Factory pattern hides the construction of the object using the factory.
             * It differs from the Simple Factory by having specific factories for each type of object. */
            Console.WriteLine("***Factory Pattern Demo***");
            AnimalFactory dogFactory = new DogFactory();
            IAnimal dog = dogFactory.CreateAnimal();
            dog.AboutMe();

            AnimalFactory catFactory = new CatFactory();
            IAnimal cat = catFactory.CreateAnimal();
            cat.AboutMe();

            Console.ReadKey();
        }
    }
}
