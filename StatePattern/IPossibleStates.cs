using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal interface IPossibleStates
    {
        void PressOnButton(TV context);
        void PressOffButton(TV context);
        void PressMuteButton(TV context);
    }
}
