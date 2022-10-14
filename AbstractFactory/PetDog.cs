using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Bark, bark petly");
        }
    }
}
