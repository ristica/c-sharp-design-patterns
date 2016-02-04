using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.BMW
{
    public class BmwFactory : CarFactory
    {
        public override Coupe CreateCoupe()
        {
            Console.WriteLine("\tBMW  => creating new coupe:");
            return new Bmw328i();
        }

        public override Limousine CreateLimousine()
        {
            Console.WriteLine("\tBMW  => creating new limousine:");
            return new Bmw750iL();
        }

        public override SuW CreateSuW()
        {
            Console.WriteLine("\tBMW  => creating new SuW:");
            return new BmwX6();
        }
    }
}
