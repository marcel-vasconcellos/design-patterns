using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Director
    {
        public void Construct(Builder builder)
        {
            // Director class is used so as to not break the single responsibility principle
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
