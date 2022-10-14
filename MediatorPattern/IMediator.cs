using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal interface IMediator
    {
        void Register(AbstractFriend friend);
        void Send(AbstractFriend fromFriend, AbstractFriend toFriend, string msg);
        void DisplayDetails();
    }
}
