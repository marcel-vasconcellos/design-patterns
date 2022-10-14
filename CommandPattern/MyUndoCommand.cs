using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class MyUndoCommand : ICommand
    {
        private Receiver receiver;

        public MyUndoCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Do()
        {
            //Perform any optional task prior to UnDo
            receiver.OptionalTaskPriorToUndo();
            receiver.Undo();
        }
     }
}
