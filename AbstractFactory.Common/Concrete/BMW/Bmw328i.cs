using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.BMW
{
    public class Bmw328i : Coupe
    {
        public override void GetName()
        {
            Console.WriteLine("\t\tBMW 328i");
        }

        public override void GetMaxSpeed()
        {
            Console.WriteLine("\t\tMax speed: 250 km/h");
        }
    }
}
