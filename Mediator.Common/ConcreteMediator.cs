using System.Collections.Generic;

namespace Mediator.Common
{
    public class ConcreteMediator<T> : IMediator<T>
    {
        private readonly List<IColleague<T>> _colleagueList= new List<IColleague<T>>();

        public void DistributeMessage(IColleague<T> sender, T message)
        {
            foreach (var c in this._colleagueList)
            {
                // not to send itself
                if (c != sender)
                {
                    c.ReceiveMessage(message);
                }
            }
        }

        public void Register(IColleague<T> colleague)
        {
            this._colleagueList.Add(colleague);
        }
    }
}
