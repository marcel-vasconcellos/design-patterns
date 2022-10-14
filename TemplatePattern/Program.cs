using System;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
               Template method lets subclasses redefine certain steps of an algorithm without
               changing the algorithm’s structure. */
            Console.WriteLine("***Template Method Pattern Demonstration***");
            BasicEngineering bs = new ComputerScience();
            Console.WriteLine("The Computer Science course includes the following subjects:");
            bs.DisplayCourseStructure();
            Console.WriteLine();
            bs = new Electronics();
            Console.WriteLine("The Electronics course includes the following subjects");
            bs.DisplayCourseStructure();
            Console.ReadLine();
        }
    }
}
