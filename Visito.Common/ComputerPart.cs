namespace Visito.Common
{
    public interface IComputerPart
    {
        void Accept(IVisitor visitor);
    }
}
