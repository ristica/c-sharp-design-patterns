using System;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common.Concrete.HONDA
{
    public class HondaCrx : ICoupe
    {
        public void GetName()
        {
            Console.WriteLine("\t\tHONDA CRX 1.6");
        }

        public void GetMaxSpeed()
        {
            Console.WriteLine("\t\t235 km/h Max speed");
        }
    }
}
