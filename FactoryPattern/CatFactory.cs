using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CatFactory : AnimalFactory
    {
        //Hidden creation of object
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
}
