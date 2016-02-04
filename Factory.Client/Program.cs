using System;
using System.IO;
using Factory.Common;

namespace Factory.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welches Fahrzeug möchten Sie erstellen?");
                Console.WriteLine();
                Console.WriteLine("COUPE => drücken Sie 'C'");
                Console.WriteLine("LIMOUSINE => drücken Sie 'L'");
                Console.WriteLine("SUV => drücken Sie 'S'");
                Console.WriteLine();
                var carType = CastInputToCarType(Console.ReadLine());

                Console.WriteLine();
                var car = CarFactory.GetCar(carType);
                Console.WriteLine("\t" + car.GetName());
                Console.WriteLine();
            }
        }

        private static CarType CastInputToCarType(string input)
        {
            switch (input)
            {
                case "C":
                    return CarType.Coupe;
                case "L":
                    return CarType.Limousine;
                case "S":
                    return CarType.SuV;
                default:
                    throw new FileNotFoundException("input existiert nicht");
            }
        }
    }
}
