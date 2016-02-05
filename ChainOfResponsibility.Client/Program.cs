using System;
using ChainOfResponsibility.Common.ConcreteHandlers;
using ChainOfResponsibility.Common.Helpers;
using ChainOfResponsibility.Common.MessageHandler;

namespace ChainOfResponsibility.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageHandler rookie = new MessageHandler(new Checker("rookie", 5000));
            IMessageHandler sophomore = new MessageHandler(new Checker("sophomore", 10000));
            IMessageHandler junior = new MessageHandler(new Checker("junior", 15000));
            IMessageHandler senior = new MessageHandler(new Checker("senior", 20000));

            rookie.RegisterNext(sophomore);
            sophomore.RegisterNext(junior);
            junior.RegisterNext(senior);

            Console.WriteLine("Put some money to prove the service:");
            var total = Console.ReadLine();

            ICheckReport report = new CheckReport(int.Parse(total));
            HandlerResponse response = rookie.Check(report);

            Console.WriteLine("The response is {0}!", response);
            Console.ReadKey();
        }
    }
}
