using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.AUDI
{
    public class AudiQ7 : SuW
    {
        public override void GetName()
        {
            Console.WriteLine("\t\tAUDI Q7");
        }

        public override void SetWheelSize()
        {
            Console.WriteLine("\t\t23 inch wheels on board");
        }
    }
}
