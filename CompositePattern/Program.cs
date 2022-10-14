using System;

namespace CompositePattern
{
    internal class Program
    {
        // Composite Pattern's objective is to handle a collection of objects in a tree-like structure
        // as if they were one. Able to add and remove nodes and give instructions to all at the same time.
        static void Main(string[] args)
        {
            // Let's imagine a school hierarchy as an example
            Console.WriteLine("***Composite Pattern Demo***");
            
            // Mathematics department creation
            Employee mathTeacher1 = new Employee { Name = "Gilson", Dept = "Mathematics", Designation = "Lecturer"};
            Employee mathTeacher2 = new Employee { Name = "Gricelda", Dept = "Mathematics", Designation = "Lecturer" };
            CompositeEmployee hodMaths = new CompositeEmployee { Name = "Mrs. S. Das", Dept = "Maths", Designation = "HOD-Maths" };
            hodMaths.AddEmployee(mathTeacher1);
            hodMaths.AddEmployee(mathTeacher2);

            // Computer science department creation
            Employee csTeacher1 = new Employee { Name = "Jorge", Dept = "Computer Science", Designation = "Lecturer" };
            Employee csTeacher2 = new Employee { Name = "Andre", Dept = "Computer Science", Designation = "Lecturer" };
            Employee csTeacher3 = new Employee { Name = "Paulo", Dept = "Computer Science", Designation = "Lecturer" };
            CompositeEmployee hodCS = new CompositeEmployee { Name = "Vanessa", Dept = "Computer Science", Designation = "HOD-CS" };
            hodCS.AddEmployee(csTeacher1);
            hodCS.AddEmployee(csTeacher2);
            hodCS.AddEmployee(csTeacher3);

            // Principal(root) creation
            CompositeEmployee principal = new CompositeEmployee { Name = "Themis", Dept = "Direction", Designation = "Principal" };
            principal.AddEmployee(hodCS);
            principal.AddEmployee(hodMaths);

            Console.WriteLine("Details of the whole hierarchy:");
            principal.DisplayDetails();

            Console.WriteLine("Computer science department details:");
            hodCS.DisplayDetails();

            Console.WriteLine("Mathematics department details:");
            hodMaths.DisplayDetails();

            Console.WriteLine("Supposedly Jorge has quit the computer science department.");
            hodCS.RemoveEmployee(csTeacher1);
            Console.WriteLine("Now the organization of the computer science department is as follows:");
            hodCS.DisplayDetails();
            Console.ReadKey();
        }
    }
}
