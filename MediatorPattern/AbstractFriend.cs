using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class AbstractFriend
    {
        IMediator mediator;
        public string Name { get; set; }
        public AbstractFriend(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SendMessage(AbstractFriend toFriend, string msg)
        {
            mediator.Send(this, toFriend, msg);
        }
        public void ReceiveMessage(AbstractFriend fromFriend, string msg)
        {
            Console.WriteLine($"{this.Name} has received a message from {fromFriend.Name} saying {msg}");
        }
    }
}
