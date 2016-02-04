using System;
using Composite.Common.Component;

namespace Composite.Common.Leaf
{
    public class Gmc : IVehicle
    {
        public void Print()
        {
            Console.WriteLine("GMC");
        }
    }
}
