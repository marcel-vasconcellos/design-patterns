using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    // This is a leaf node
    internal class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"\t {Name} works in {Dept} department. Designation: {Designation}");
        }
    }
}
