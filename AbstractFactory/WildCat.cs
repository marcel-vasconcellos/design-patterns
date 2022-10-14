using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WildCat : ICat
    {
        public void AboutMe()
        {
            Console.WriteLine("Meow meows wildly");
        }
    }
}
