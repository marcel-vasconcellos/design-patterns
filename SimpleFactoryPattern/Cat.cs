using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class Cat : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("Cat says: Meow, meow.");
        }
    }
}
