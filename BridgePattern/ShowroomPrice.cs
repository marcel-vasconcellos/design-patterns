using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class ShowroomPrice : IPrice
    {
        public void DisplayDetails(string productType)
        {
            Console.WriteLine($"\n{productType} price online is : 3000$");
        }
    }
}
