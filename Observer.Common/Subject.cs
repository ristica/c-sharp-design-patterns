using System.Collections.Generic;

namespace Observer.Common
{
    public class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            if (!this._observers.Contains(observer))
                this._observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            if (this._observers.Contains(observer))
                this._observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var o in this._observers)
            {
                o.Update(message);
            } 
        }
    }
}
