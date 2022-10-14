using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Context
    {
        public string input;
        private string Input { get; set; }
        public string output;
        private string Output { get; set; }
        public Context(string input)
        {
            this.input = input;
        }
    }
}
