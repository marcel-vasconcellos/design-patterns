using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Interpreter Pattern Demonstation1.***\n");
            Console.WriteLine(" It will validate first three digit of a valid number.");

            string inputString = "789";
            EvaluateInputWithContext(inputString);
            inputString = "456";
            EvaluateInputWithContext(inputString);
            inputString = "123";
            EvaluateInputWithContext(inputString);
            inputString = "075";
            EvaluateInputWithContext(inputString);
            inputString = "Ku79";//invalid input
            EvaluateInputWithContext(inputString);
            Console.ReadLine();
        }
        public static void EvaluateInputWithContext(string inputString)
        {
            Context context = new Context(inputString);
            //Building the parse tree
            List<InputExpression> expTree = new List<InputExpression>();
            expTree.Add(new HundredExpression());
            expTree.Add(new TensExpression());
            expTree.Add(new UnitExpression());
            // Interpret the input
            foreach (InputExpression inputExp in expTree)
            {
                inputExp.Interpret(context);
            }
            if (!context.output.Contains("*"))
                Console.WriteLine($" {context.input} is interpreted as{ context.output}");
            else
            {
                Console.WriteLine($" {context.input} is not a valid input.");
            }
        }
    }
}
