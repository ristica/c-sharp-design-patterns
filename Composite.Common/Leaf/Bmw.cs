using System;
using Composite.Common.Component;

namespace Composite.Common.Leaf
{
    public class Bmw : IVehicle
    {
        public void Print()
        {
            Console.WriteLine("BMW");
        }
    }
}
