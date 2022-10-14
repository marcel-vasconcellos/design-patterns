using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Subject : ISubject
    {
        List<IObserver> observerList = new List<IObserver>();
        private int flag;
        public int Flag
        {
            get 
            { 
                return flag; 
            }
            set 
            { 
                flag = value;
                NotifyRegisteredUsers(flag);
            }
        }

        public void Register(IObserver anObserver) 
        {
            observerList.Add(anObserver);
        }

        public void Unregister(IObserver anObserver)
        {
            observerList.Remove(anObserver);
        }

        public void NotifyRegisteredUsers(int i)
        {
            foreach(IObserver anObserver in observerList)
            {
                anObserver.Update(i);
            }
        }
    }
}
