using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Mute : IPossibleStates
    {
        public Mute()
        {
            Console.WriteLine("TV is mute now.");
        }
        public void PressOnButton(TV context)
        {
            Console.WriteLine("TV was in mute mode now. Moving to on state.");
            context.CurrentState = new On();
        }
        public void PressOffButton(TV context)
        {
            Console.WriteLine("TV was on. So, switching off the TV.");
            context.CurrentState = new Off();
        }
        public void PressMuteButton(TV context)
        {
            Console.WriteLine("TV was mute. So, ignoring mute button press operation.");
        }
    }
}
