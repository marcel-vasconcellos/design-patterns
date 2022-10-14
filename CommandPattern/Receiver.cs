using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Receiver
    {
        public void Undo()
        {
            Console.WriteLine("Executing Undo command.");
        }
        public void Redo()
        {
            Console.WriteLine("Executing Redo command");
        }

        // Optional method to perform any prior tasks before undo or redo
        public void OptionalTaskPriorToUndo()
        {
            Console.WriteLine("Executing optional tasks prior to undo");
        }
        public void OptionalTaskPriorToRedo()
        {
            Console.WriteLine("Executing optional tasks prior to redo");
        }
    }
}
