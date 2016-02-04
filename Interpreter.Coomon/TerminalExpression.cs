using System;

namespace Interpreter.Coomon
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("TerminalExpression.Inerpret()");
        }
    }
}
