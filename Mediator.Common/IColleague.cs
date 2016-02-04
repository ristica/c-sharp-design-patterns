namespace Mediator.Common
{
    public interface IColleague<T>
    {
        string GetName();
        void SendMessage(IMediator<T> mediator, T message);   
        void ReceiveMessage(T message);
    }
}
