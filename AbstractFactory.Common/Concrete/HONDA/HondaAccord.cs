using System;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common.Concrete.HONDA
{
    public class HondaAccord : ILimousine
    {
        public void GetName()
        {
            Console.WriteLine("\t\tHONDA Accord 2.0");
        }

        public void HasAirCon()
        {
            Console.WriteLine("\t\tAC on board");
        }
    }
}
