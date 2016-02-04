using System;
using Bridge.Common.Abstraction;

namespace Bridge.Common.RefinedAbstraction
{
    public class Rect : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("\tdraw a new rect!");
        }

        public override void Fill()
        {
            Console.Write("\tfill rect");
            this.Painter.FillShape();
        }
    }
}
