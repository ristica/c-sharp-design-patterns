using System;
using Bridge.Common.AbstractImplementor;

namespace Bridge.Common.ConcreteImplementor
{
    public class BluePainter : IPainter
    {
        public void FillShape()
        {
            Console.Write(" with BLUE color!");
        }
    }
}
