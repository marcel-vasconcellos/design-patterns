using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    internal class TensExpression : InputExpression
    {
        public override void Interpret(Context context)
        {
            string tens = context.input.Substring(1, 1);
            context.output += GetWord(tens) + " ten(s) ";
        }
    }
}
