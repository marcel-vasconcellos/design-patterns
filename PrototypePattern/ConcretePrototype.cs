using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id, string info) : base(id, info)
        {
            Console.WriteLine("This is Concrete Prototype #{0} being created. The info is: {1}", id, info);
        }
        // This method returns a shallow copy and is the defining characteristic of Prototype Pattern
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

        // This method returns a deep copy and is the defining characteristic of Prototype Pattern
        public Prototype DeepClone()
        {
            Prototype clone = (Prototype)this.MemberwiseClone();
            return clone;
        }
    }
}
