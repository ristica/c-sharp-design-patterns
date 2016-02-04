using System;
using Bridge.Common.Abstraction;
using Bridge.Common.ConcreteImplementor;
using Bridge.Common.RefinedAbstraction;

namespace Bridge.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RECT =>");
            Shape rect = new Rect();
            rect.Painter = new BluePainter();

            rect.Draw();
            rect.Fill();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CIRCLE =>");

            Shape circle = new Circle();
            circle.Painter = new RedPainter();

            circle.Draw();
            circle.Fill();

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
