using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WildAnimalFactory : IAnimalFactory
    {
        public ICat GetCat()
        {
            return new WildCat();
        }

        public IDog GetDog()
        {
            return new WildDog();
        }
    }
}
