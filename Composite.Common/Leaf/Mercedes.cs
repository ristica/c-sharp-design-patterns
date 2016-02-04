using System;
using Composite.Common.Component;

namespace Composite.Common.Leaf
{
    public class Mercedes : IVehicle
    {
        public void Print()
        {
            Console.WriteLine("MERCEDES");
        }
    }
}
