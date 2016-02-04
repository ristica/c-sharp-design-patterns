using System;
using System.Globalization;
using AbstractFactory.Common.Abstract;
using AbstractFactory.Common.Concrete.AUDI;
using AbstractFactory.Common.Concrete.BMW;
using AbstractFactory.Common.Concrete.HONDA;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // AUDI
            CarFactory carFactory = new AudiFactory();
            Console.WriteLine();

            var audiCoupe = carFactory.CreateCoupe();
            audiCoupe.GetName();
            audiCoupe.GetMaxSpeed();
            Console.WriteLine();

            var audiLimousine = carFactory.CreateLimousine();
            audiLimousine.GetName();
            audiLimousine.HasAirCon();
            Console.WriteLine();

            var audiSuw = carFactory.CreateSuW();
            audiSuw.GetName();
            audiSuw.SetWheelSize();
            
            // BMW
            carFactory = new BmwFactory();
            Console.WriteLine();

            var bmwCoupe = carFactory.CreateCoupe();
            bmwCoupe.GetName();
            bmwCoupe.GetMaxSpeed();
            Console.WriteLine();

            var bmwLimousine = carFactory.CreateLimousine();
            bmwLimousine.GetName();
            bmwLimousine.HasAirCon();
            Console.WriteLine();

            var bmwSuw = carFactory.CreateSuW();
            bmwSuw.GetName();
            bmwSuw.SetWheelSize();
            Console.WriteLine();

            // HONDA
            ICarFactory hondaFactory = new HondaFactory();
            Console.WriteLine();

            var hondaCoupe = hondaFactory.CreateCoupe();
            hondaCoupe.GetName();
            hondaCoupe.GetMaxSpeed();
            Console.WriteLine();

            var hondaLimousine = hondaFactory.CreateLimousine();
            hondaLimousine.GetName();
            hondaLimousine.HasAirCon();
            Console.WriteLine();

            var hondaSuw = hondaFactory.CreateSuW();
            hondaSuw.GetName();
            hondaSuw.SetWheelSize();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
