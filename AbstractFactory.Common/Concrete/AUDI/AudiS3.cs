using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.AUDI
{
    public class AudiS3 : Coupe
    {
        public override void GetName()
        {
            Console.WriteLine("\t\tAUDI S3");
        }

        public override void GetMaxSpeed()
        {
            Console.WriteLine("\t\tMax speed: 240 km/h");
        }
    }
}
