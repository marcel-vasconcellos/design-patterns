using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The purpose of a Prototype Pattern is to implement the clone method in order to be able to create 
             * a new modifiable oject based on a previous existing object with information */
            Console.WriteLine("***Prototype Pattern Demo***");

            string inputId, inputInfo;
            Console.WriteLine("Input Id of prototype 1:");
            inputId = Console.ReadLine();
            Console.WriteLine("Input Info of prototype 1:");
            inputInfo = Console.ReadLine();
            ConcretePrototype concretePrototype1 = new ConcretePrototype(inputId, inputInfo);
            Console.WriteLine("Now we will try to create a new employee using: " +
                "ConcretePrototype concretePrototype2 = concretePrototype1;");
            ConcretePrototype concretePrototype2 = concretePrototype1;
            Console.WriteLine("Input Id of prototype 2:");
            inputId = Console.ReadLine();
            concretePrototype2.SetId = inputId;
            Console.WriteLine("Input Info of prototype 2:");
            inputInfo = Console.ReadLine();
            concretePrototype2.SetInfo = inputInfo;

            Console.WriteLine("Concrete Prototype 1 Properties: Id: {0} Info: {1}", 
                concretePrototype1.GetId,concretePrototype1.GetInfo);
            Console.WriteLine("Concrete Prototype 2 Properties: Id: {0} Info: {1}",
                concretePrototype2.GetId, concretePrototype2.GetInfo);
            Console.WriteLine("You can see that in spite of inputting different information, " +
                "they end up the same because they were passed by reference via the shallow copy. Now let's use the Clone method from the prototype:");
            ConcretePrototype clonedPrototype = (ConcretePrototype)concretePrototype1.Clone();

            Console.WriteLine("Input Id of cloned prototype:");
            inputId = Console.ReadLine();
            clonedPrototype.SetId = inputId;
            Console.WriteLine("Input Info of cloned prototype:");
            inputInfo = Console.ReadLine();
            clonedPrototype.SetInfo = inputInfo;

            Console.WriteLine("Concrete Prototype 1 Properties: Id: {0} Info {1}",
                concretePrototype1.GetId, concretePrototype1.GetInfo);
            Console.WriteLine("Cloned Prototype Properties: Id: {0} Info: {1}",
                clonedPrototype.GetId, clonedPrototype.GetInfo);
            Console.WriteLine("Cloned Prototype has new addresses for memory and copies by value.");
            Console.ReadKey();


        }
    }
}
