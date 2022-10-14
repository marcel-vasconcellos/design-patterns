using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class FloorDecorator : AbstractDecorator
    {
        public FloorDecorator(AbstractHome home) : base(home)
        {
            this.AdditionalPrice = 2000;
        }
        public override void MakeHome()
        {
            base.MakeHome();
            // The purpose of Decorator patter is to use the method below without the need of inheritance
            AddFloor();
        }
        // This method will be used without inheritance and will add a price to the construction of the house
        private void AddFloor()
        {
            Console.WriteLine($"Additional Floor added. Pay additional {AdditionalPrice}$ for it.");
        }
    }
}
