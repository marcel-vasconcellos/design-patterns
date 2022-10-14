using System;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Iterator Pattern Demo***");
            ISubjects ScienceSubjects = new Science();
            ISubjects ArtsSubjects = new Arts();

            IIterator IteratorForScience = ScienceSubjects.CreateIterator();
            IIterator IteratorForArts = ArtsSubjects.CreateIterator();

            Console.WriteLine("\n Science subjects:");
            Print(IteratorForScience);
            Console.WriteLine("\n Arts subjects:");
            Print(IteratorForArts);
            Console.ReadKey();

            static void Print(IIterator iterator)
            {
                while (!iterator.IsDone())
                {
                    Console.WriteLine(iterator.Next());
                }
            }
        }
    }
}
