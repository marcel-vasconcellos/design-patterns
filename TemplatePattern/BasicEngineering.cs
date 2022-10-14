using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal abstract class BasicEngineering
    {
        private void Math()
        {
            Console.WriteLine("1. Mathematics");
        }
        private void SoftSkills()
        {
            Console.WriteLine("2. Softskills");
        }
        public abstract void SpecialPaper();

        // This is the "Template" method:
        public void DisplayCourseStructure()
        {
            // Common property:
            Math();
            SoftSkills();
            // Specialized Paper:
            SpecialPaper();
        }

    }
}
