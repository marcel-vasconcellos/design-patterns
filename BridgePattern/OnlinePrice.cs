using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class OnlinePrice : IPrice
    {
        public void DisplayDetails(string productType)
        {
            Console.WriteLine($"\n{productType} price online is : 2000$");
        }
    }
}
