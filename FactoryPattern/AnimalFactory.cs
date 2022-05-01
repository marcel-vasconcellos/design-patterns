using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class AnimalFactory
    {
        // Creation of object will be handled in the subclasses
        public abstract IAnimal CreateAnimal();
    }
}
