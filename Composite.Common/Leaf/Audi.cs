using System;
using Composite.Common.Component;

namespace Composite.Common.Leaf
{
    public class Audi : IVehicle
    {
        public void Print()
        {
            Console.WriteLine("AUDI");
        }
    }
}
