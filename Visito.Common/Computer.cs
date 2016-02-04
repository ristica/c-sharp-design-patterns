using System.Collections.Generic;

namespace Visito.Common
{
    public class Computer : IComputerPart
    {
        private readonly List<IComputerPart> _parts;

        public Computer()
        {
            this._parts = new List<IComputerPart>
            {
                 new Mouse(), new Keyboard(), new Monitor()
            };
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var part in this._parts)
            {
                part.Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
}
