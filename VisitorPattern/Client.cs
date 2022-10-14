using System;

namespace VisitorPattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern***");
            IVisitor visitor = new Visitor();
            MyClass myClass = new MyClass();
            myClass.Accept(visitor);
            Console.ReadKey();
        }
    }
}
