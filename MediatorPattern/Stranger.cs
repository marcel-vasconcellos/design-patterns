using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Stranger : AbstractFriend
    {
        public Stranger(IMediator mediator) : base(mediator)
        {

        }
    }
}
