namespace Visito.Common
{
    public interface IVisitor
    {
        void Visit(Computer c);
        void Visit(Keyboard k);
        void Visit(Monitor m);
        void Visit(Mouse mouse);
    }
}
