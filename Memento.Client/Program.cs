using System;
using Memento.Common;

namespace Memento.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var origin = Origin.Factory.CreateNewInstance("Fernkorngasse 56/410", "1100", "Wien");
            Console.WriteLine("SET STATE...");
            Console.WriteLine("\n\t" + origin.Street + " ," + origin.Zip + " " + origin.City);

            Console.WriteLine();

            Console.WriteLine("CHANGE STATE...");
            origin.Street = "Pingostrasse 222";
            origin.Zip = "2222";
            origin.City = "Gotham City";
            Console.WriteLine("\n\t" + origin.Street + " ," + origin.Zip + " " + origin.City);

            Console.WriteLine();

            Console.WriteLine("REVERT...");
            origin.RevertOrigin();
            Console.WriteLine("\n\t" + origin.Street + " ," + origin.Zip + " " + origin.City);

            Console.ReadKey();
        }
    }
}
