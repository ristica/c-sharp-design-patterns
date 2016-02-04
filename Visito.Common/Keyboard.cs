namespace Visito.Common
{
    public class Keyboard : IComputerPart
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
