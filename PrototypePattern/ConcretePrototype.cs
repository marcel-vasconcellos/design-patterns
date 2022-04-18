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
        // returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

        // returns a shallow copy
        public Prototype DeepClone()
        {
            Prototype clone = (Prototype)this.MemberwiseClone();
            return clone;
        }
    }
}
