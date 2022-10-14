using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class PaintDecorator : AbstractDecorator
    {
        public PaintDecorator(AbstractHome home) : base(home)
        {
            this.AdditionalPrice = 5000;
        }
        public override void MakeHome()
        {
            base.MakeHome();
            // The purpose of Decorator patter is to use the method below without the need of inheritance
            PaintHome();
        }
        private void PaintHome()
        {
            Console.WriteLine($"Painting done. Pay additional ${AdditionalPrice} for it.");
        }
    }
}
