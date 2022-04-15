using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern Demonstration:");
            Singleton1 firstInstance = Singleton1.GetInstance;
            Singleton1 secondInstance = Singleton1.GetInstance;

            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The first and second instances are the same");
            }
            else
            {
                Console.WriteLine("The instances are different");
            }
            Console.Read();
        }
    }
}
