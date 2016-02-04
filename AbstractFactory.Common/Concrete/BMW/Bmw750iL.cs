using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.BMW
{
    public class Bmw750iL : Limousine
    {
        public override void GetName()
        {
            Console.WriteLine("\t\tBMW 750iL");
        }

        public override void HasAirCon()
        {
            Console.WriteLine("\t\tAC is on board!");
        }
    }
}
