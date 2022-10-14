using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Friend : AbstractFriend
    {
        public Friend(IMediator mediator) : base(mediator)
        { 
        }
    }
}
