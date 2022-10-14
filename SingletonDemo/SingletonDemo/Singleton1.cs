using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton1
    {
        // Private constructor is used to prevent the creation of instances with the new keyword outside of this class
        private Singleton1() 
        {
            Console.WriteLine("Private constructor is called.");
            Console.WriteLine("Exit private constructor.");
        }

        static Singleton1() 
        {
            Console.WriteLine("Static constructor is called.");
            instance = new Singleton1();
            TotalInstances++;
            Console.WriteLine("Singleton instance is created. Numer of instances: {0}.", TotalInstances);
            Console.WriteLine("Exiting static constructor.");
        }
        private static Singleton1 instance = null;
        private static int TotalInstances;

        // This code below is the defining characteristic of a Singleton Pattern
        public static Singleton1 GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
    }
}
