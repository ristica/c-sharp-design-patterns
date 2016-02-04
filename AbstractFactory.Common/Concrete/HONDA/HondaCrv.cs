using System;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common.Concrete.HONDA
{
    public class HondaCrv : ISuW
    {
        public void GetName()
        {
            Console.WriteLine("\t\tHONDA CR-V 2.0 i VTEC");
        }

        public void SetWheelSize()
        {
            Console.WriteLine("\t\t19 inch");
        }
    }
}
