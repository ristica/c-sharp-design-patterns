namespace Visito.Common
{
    public class Monitor : IComputerPart
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
