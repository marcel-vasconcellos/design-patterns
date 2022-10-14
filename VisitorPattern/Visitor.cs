using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class Visitor : IVisitor
    {
        public void Visit(MyClass myClassElement)
        {
            Console.WriteLine("Visitor will visit and change the value of the integer");
            myClassElement.MyInt = 10;
            Console.WriteLine("Visitor left");
        }
    }
}
