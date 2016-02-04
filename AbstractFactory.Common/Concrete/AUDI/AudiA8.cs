using System;
using AbstractFactory.Common.Abstract;

namespace AbstractFactory.Common.Concrete.AUDI
{
    public class AudiA8 : Limousine
    {
        public override void GetName()
        {
            Console.WriteLine("\t\tAUDI A8");
        }

        public override void HasAirCon()
        {
            Console.WriteLine("\t\tMultizone AC is on board");
        }
    }
}
