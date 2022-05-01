using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("Dog says: Bark, bark, bark!");
        }
    }
}
