using System;
using Facade.Common.Facade;

namespace Facade.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Creating a new AUDI...");
            Console.WriteLine();

            var facade = new CarFacade();
            facade.CreateAudi();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
