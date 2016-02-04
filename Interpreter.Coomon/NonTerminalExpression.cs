using System;

namespace Interpreter.Coomon
{
    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("NonTerminalExpression.Interpret()");
        }
    }
}
