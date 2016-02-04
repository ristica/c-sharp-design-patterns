using System;

namespace Mediator.Common
{
    public class ConcreteColleague<T> : IColleague<T>
    {
        private readonly string _name;

        public ConcreteColleague(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SendMessage(IMediator<T> mediator, T message)
        {
            mediator.DistributeMessage(this, message);
        }

        public void ReceiveMessage(T message)
        {
            Console.WriteLine(this._name + " received " + message);
        }
    }
}
