using System;
using Visito.Common;

namespace Visitor.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var pc = new Computer();
            pc.Accept(new Visito.Common.Visitor());

            Console.ReadKey();
        }
    }
}
