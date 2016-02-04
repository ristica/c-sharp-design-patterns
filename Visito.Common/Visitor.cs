using System;

namespace Visito.Common
{
    public class Visitor: IVisitor
    {
        public void Visit(Computer c)
        {
            Console.WriteLine("Visited: PC");
        }

        public void Visit(Keyboard k)
        {
            Console.WriteLine("Visitied: KEYBOARD");
        }

        public void Visit(Monitor m)
        {
            Console.WriteLine("Visited: MONITOR");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Visited: MOUSE");
        }
    }
}
