using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class PetCat : ICat
    {
        public void AboutMe()
        {
            Console.WriteLine("Meow meow petly");
        }
    }
}
