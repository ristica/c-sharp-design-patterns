using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.BMW
{
    public class BmwX6 : SuW
    {
        public override void GetName()
        {
            Console.WriteLine("\t\tBMW X6");
        }

        public override void SetWheelSize()
        {
            Console.WriteLine("\t\t22 inch wheels on board");
        }
    }
}
