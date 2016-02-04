namespace Mediator.Common
{
    public interface IMediator<T>
    { 
        void DistributeMessage(IColleague<T> sender, T message);  
        void Register(IColleague<T> colleague);
    }
}
