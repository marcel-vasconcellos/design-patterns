using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class ElectronicGoods
    {
        public IPrice Price { get; set; }
        public string ProductType { get; set; }
        public abstract void Details();
    }
}
