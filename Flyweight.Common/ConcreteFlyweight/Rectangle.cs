using System;
using Flyweight.Common.Flyweight;

namespace Flyweight.Common.ConcreteFlyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }
}