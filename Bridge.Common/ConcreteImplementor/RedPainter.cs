using System;
using Bridge.Common.AbstractImplementor;

namespace Bridge.Common.ConcreteImplementor
{
    public class RedPainter : IPainter
    {
        public void FillShape()
        {
            Console.Write(" with RED color!");
        }
    }
}
