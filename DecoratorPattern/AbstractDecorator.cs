using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class AbstractDecorator : AbstractHome
    {
        protected AbstractHome home;
        public AbstractDecorator(AbstractHome home)
        {
            this.home = home;
            this.AdditionalPrice = 0;
        }
        public override void MakeHome()
        {
            home.MakeHome();
        }
    }
}
