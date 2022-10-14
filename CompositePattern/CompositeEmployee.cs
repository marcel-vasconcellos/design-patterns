using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }

        private List<IEmployee> subordinateList = new List<IEmployee>();

        public void  AddEmployee(IEmployee e)
        {
            subordinateList.Add(e);
        }

        public void RemoveEmployee(IEmployee e) 
        {
            if (subordinateList.Contains(e))
            {
                subordinateList.Remove(e);
            }
            else 
            {
                Console.WriteLine("Employee does not exist.");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"\t {Name} works in {Dept} department. Designation: {Designation}");
            foreach(IEmployee e in subordinateList)
            {
                e.DisplayDetails();
            }
        }
    }
}
