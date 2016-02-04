using System;

namespace Observer.Common
{
    public class ConcreteObserver : IObserver
    {
        public string Name { get; set; }

        public ConcreteObserver(string name)
        {
            this.Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine("\n\t" + this.Name + " got message: " + message);
        }
    }
}
