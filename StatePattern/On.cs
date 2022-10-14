using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class On : IPossibleStates
    {
        public On()
        {
            Console.WriteLine("TV is on now");
        }
        public void PressOnButton(TV context)
        {
            Console.WriteLine("TV is already in on state. Ignoring on button press operation.");
        }
        public void PressOffButton(TV context)
        {
            Console.WriteLine("TV was on. So, switching off the TV.");
            context.CurrentState = new Off();
        }
        public void PressMuteButton(TV context)
        {
            Console.WriteLine("TV was on. So, moving to silent mode.");
            context.CurrentState = new Mute();
        }
    }
}
