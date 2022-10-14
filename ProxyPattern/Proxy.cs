using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : Subject
    {   
        // Proxy class will handle instantiation and the actual call to the original method.
        Subject subject;
        public override void DoSomeWork()
        {
            Console.WriteLine("Welcome, user.");
            /* Lazy instantiation, we won't instantiate a new object until the method is called */
            if(subject == null)
            {
                subject = new ConcreteSubject();
            }
            subject.DoSomeWork();
        }
    }
}
