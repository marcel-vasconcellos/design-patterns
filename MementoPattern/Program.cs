using System;
using System.Collections.Generic;

namespace MementoPattern
{
    internal class Program
    {
        static Originator originatorObject;
        static Memento currentMemento;
        static void Main(string[] args)
        {
            Console.WriteLine("***Memento Pattern Demo***");
            originatorObject = new Originator();
            IList<Memento> savedStates = new List<Memento>();
            // Adding a memento to the list
            savedStates.Add(originatorObject.CurrentMemento());
            // Snapshot #1 
            originatorObject.State = "Snapshot #1";
            savedStates.Add(originatorObject.CurrentMemento());
            // Snapshot #2
            originatorObject.State = "Snapshot #2";
            savedStates.Add(originatorObject.CurrentMemento());
            // Snapshot #3 will not be added as a memento
            originatorObject.State = "Snapshot #3";
            Console.WriteLine("\nCurrently available restore points are:");
            foreach (Memento memento in savedStates)
            {
                Console.WriteLine(memento.State);
            }
            // Not to go back to another snapshot
            Console.WriteLine("Performing undo function.");
            for(int i = savedStates.Count; i > 0; i--)
            {
                currentMemento = savedStates[i -1];
                originatorObject.RestoreMemento(currentMemento);
            }
            // Performing redo function
            for(int i = 0; i < savedStates.Count; i++)
            {
                currentMemento = savedStates[i];
                originatorObject.RestoreMemento(currentMemento);
            }
            Console.ReadKey();
        }
    }
}
