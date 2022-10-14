using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    abstract class Receiver
    {
        protected Receiver nextReceiver;
        public void NextReceiver(Receiver nextReceiver)
        {
            this.nextReceiver = nextReceiver;
        }
        public abstract void HandleMessage(Message message);
    }
}
