using System;
using Prototype.Common.Concrete;

namespace Prototype.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var audi = new AudiPrototype();
            var prototype = audi.Clone();
            prototype.AutomaticGear = true;

            Console.WriteLine("Name? {0}", prototype.Name);
            Console.WriteLine("Automatic? {0}", prototype.AutomaticGear);
            Console.WriteLine("Max speed: {0}", prototype.MaxSpeed);

            Console.ReadKey();  
        }
    }
}
