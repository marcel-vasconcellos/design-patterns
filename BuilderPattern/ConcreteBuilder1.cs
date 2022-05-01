using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class ConcreteBuilder1 : Builder
    {
        // This is the code we want to hide
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartA");
        }
        public override void BuildPartB()
        {
            _product.Add("PartB");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
}
