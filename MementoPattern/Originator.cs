using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Originator
    {
        // Originator creates a memento that contains
        // a snapshot of its current internal state.
        // It uses a memento to restore  its internal state.
        private string state;
        Memento myMemento;
        public Originator()
        {
            state = "Snapshot #0. (Born state)";
            Console.WriteLine($"Originator's current state is: {state}");
        }
        public string State
        {
            get 
            { 
                return state; 
            }
            set 
            {
                Console.WriteLine($"Originator's current state is: {state}");
                state = value; 
            }
        }
        public Memento CurrentMemento()
        {
            myMemento = new Memento();
            myMemento.State = state;
            return myMemento;
        }

        public void RestoreMemento(Memento restoreMemento)
        {
            this.state = restoreMemento.State;
            Console.WriteLine($"Restored to state: {state}");
        }
    }
}
