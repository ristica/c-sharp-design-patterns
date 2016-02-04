using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.AUDI
{
    public class AudiFactory : CarFactory
    {
        public override Coupe CreateCoupe()
        {
            Console.WriteLine("\tAUDI => creating new coupe:");
            return new AudiS3();
        }

        public override Limousine CreateLimousine()
        {
            Console.WriteLine("\tAUDI => creating new limousine:");
            return new AudiA8();
        }

        public override SuW CreateSuW()
        {
            Console.WriteLine("\tAUDI => creating new SuW:");
            return new AudiQ7();
        }
    }
}
