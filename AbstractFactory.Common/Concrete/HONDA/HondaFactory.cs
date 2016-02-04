using System;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common.Concrete.HONDA
{
    public class HondaFactory : ICarFactory
    {
        public ICoupe CreateCoupe()
        {
            Console.WriteLine("\tHONDA => creating new coupe:");
            return new HondaCrx();
        }

        public ILimousine CreateLimousine()
        {
            Console.WriteLine("\tHONDA => creating new limousine:");
            return new HondaAccord();
        }

        public ISuW CreateSuW()
        {
            Console.WriteLine("\tHONDA => creating new SuW:");
            return new HondaCrv();
        }
    }
}
