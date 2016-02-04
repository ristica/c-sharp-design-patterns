using System;
using Builder.Common.ProductBuilder;

namespace Builder.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CarBuilder();

            builder.SetName("AUDI A8");
            builder.SetColour("red");
            builder.SetMaxSpeed(250);
            builder.SetWheelsCount(4);

            var car = builder.GetResult();
            Console.WriteLine("Car built:");
            Console.WriteLine("\tName  : {0}", car.Name);
            Console.WriteLine("\tColour: {0}", car.Colour);
            Console.WriteLine("\tSpeed : {0}", car.Speed);
            Console.WriteLine("\tWheels: {0}", car.Wheels);
            Console.WriteLine(Console.ReadKey());
        }
    }
}
