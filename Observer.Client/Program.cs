using System;
using Observer.Common;

namespace Observer.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Subject();
            IObserver a = new ConcreteObserver("Observer A");
            IObserver b = new ConcreteObserver("Observer B");
            IObserver c = new ConcreteObserver("Observer C");

            s.RegisterObserver(a);
            s.RegisterObserver(b);
            s.RegisterObserver(c);

            Console.WriteLine("Registered 3 observer...");
            Console.WriteLine("Notify all observer:");
            s.NotifyObservers("Hello observers!");

            Console.WriteLine();  
            
            s.UnregisterObserver(b);

            Console.WriteLine("Removed observer B...");
            s.NotifyObservers("Hello observers!");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
