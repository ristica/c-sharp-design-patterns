using System;
using Flyweight.Common.Factory;
using Flyweight.Common.Flyweight;

namespace Flyweight.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();

            var numObjs = sof.TotalObjectsCreated;

            Console.WriteLine("\nTotal objects created = {0}", numObjs);
            Console.ReadKey();
        }
    }
}
