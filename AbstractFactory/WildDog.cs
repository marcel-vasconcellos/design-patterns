using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WildDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Bark wildly");
        }
    }
}
