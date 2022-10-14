using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class TV
    {
        private IPossibleStates currentState;
        public IPossibleStates CurrentState
        {
            get 
            { 
                return currentState; 
            }
            set
            {
                currentState = value;
            }
        }
        public TV()
        {
            this.currentState = new Off();
        }
        public void ExecuteOffButton()
        {
            Console.WriteLine("You pressed off button");
            currentState.PressOffButton(this);
        }
        public void ExecuteOnButton()
        {
            Console.WriteLine("You pressed on button.");
            currentState.PressOnButton(this);
        }
        public void ExecuteMuteButton()
        {
            Console.WriteLine("You pressed mute button");
            currentState.PressMuteButton(this);
        }
    }
}
