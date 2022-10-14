using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class MyClass : IOriginalInterface
    {
        private int myInt = 5;

        public int MyInt { 
            get { return myInt; } 
            set { myInt = value; } 
        }
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer:\n{0}", myInt);
            visitor.Visit(this);
            Console.WriteLine("Value of the integer after visit:\n{0}", myInt);
        }
    }
}
