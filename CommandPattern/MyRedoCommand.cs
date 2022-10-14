using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class MyRedoCommand : ICommand
    {
        private Receiver receiver;
        public MyRedoCommand(Receiver receive)
        {
            this.receiver = receive;
        }

        public void Do()
        {
            // Perform any prior tasks before ReDo
            receiver.OptionalTaskPriorToRedo();
            receiver.Redo();
        }
    }
}
