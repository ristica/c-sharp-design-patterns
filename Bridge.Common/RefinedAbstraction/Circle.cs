using System;
using Bridge.Common.Abstraction;

namespace Bridge.Common.RefinedAbstraction
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("\tdraw a new circle!");
        }

        public override void Fill()
        {
            Console.Write("\tfill circle");
            this.Painter.FillShape();
        }
    }
}
