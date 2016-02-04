using System;
using Proxy.Common.Object;

namespace Proxy.Common.RealObject
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.Write("car has been driven...");
        }
    }
}
