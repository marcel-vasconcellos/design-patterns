using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    internal class HundredExpression : InputExpression
    {
        public override void Interpret(Context context)
        {
            string hundreds = context.input.Substring(0,1);
            context.output += GetWord(hundreds) + " hundred(s) ";
        }
    }
}
