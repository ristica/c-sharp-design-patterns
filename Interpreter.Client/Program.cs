using System;
using System.Collections.Generic;
using Interpreter.Coomon;

namespace Interpreter.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();

            var list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            list.Add(new TerminalExpression());

            foreach (var ex in list)
            {
                ex.Interpret(ctx);
            }

            Console.ReadKey();
        }
    }
}
