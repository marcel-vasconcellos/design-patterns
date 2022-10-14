using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Off : IPossibleStates
    {
        public Off()
        {
            Console.WriteLine("The TV is off now.");
        }
        public void PressOnButton(TV context)
        {
            Console.WriteLine("TV was off. Going from off to on state.");
            context.CurrentState = new On();
        }
        public void PressOffButton(TV context)
        {
            Console.WriteLine("TV was already off. Ignoring off button press operation");
        }
        public void PressMuteButton(TV context)
        {
            Console.WriteLine("TV was off. Ignoring mute button press operation");
        }
    }
}
