using System;
using Mediator.Common;

namespace Mediator.Client
{
    /// <summary>
    /// concrete classes don't need to know about other
    /// concrete classes (colleagues)
    /// they just needs to know about mediator
    /// mediator distributes the messages to other colleagues
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IColleague<string> colleagueA = new ConcreteColleague<string>("Colleague A");
            IColleague<string> colleagueB = new ConcreteColleague<string>("Colleague B");
            IColleague<string> colleagueC = new ConcreteColleague<string>("Colleague C");

            IMediator<string> mediator = new ConcreteMediator<string>();

            mediator.Register(colleagueA);
            mediator.Register(colleagueB);
            mediator.Register(colleagueC);

            colleagueC.SendMessage(mediator, "message from " + colleagueC.GetName() + "!");

            Console.ReadKey();
        }
    }
}
