using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class Arts : ISubjects
    {
        private string[] Subjects;
        public Arts() 
        {
            Subjects = new[] {"Impressionism", "Modernism"};
        }

        public IIterator CreateIterator()
        {
            return new ArtsIterator(Subjects);
        }
    }
}
