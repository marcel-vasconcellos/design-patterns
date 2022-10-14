using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    internal abstract class InputExpression
    {
        public abstract void Interpret(Context context);
        public string GetWord(string str)
        {
            switch (str)
            {
                case "1":
                    return "One";
                case "2":
                    return "Two";
                case "3":
                    return "Three";
                case "4":
                    return "Four";
                case "5":
                    return "Five";
                case "6":
                    return "Six";
                case "7":
                    return "Seven";
                case "8":
                    return "Eight";
                case "9":
                    return "Nine";
                case "0":
                    return "Zero";
                    default:
                    return "*";
            }
        }
    }
}
