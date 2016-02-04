namespace Visito.Common
{
    public class Mouse : IComputerPart
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
