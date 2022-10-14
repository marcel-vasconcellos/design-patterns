using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    internal class UnitExpression : InputExpression
    {
        public override void Interpret(Context context)
        {
            string units = context.input.Substring(2, 1);
            context.output += "and " + GetWord(units);
        }
    }
}
