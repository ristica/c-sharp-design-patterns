using System;
using Strategy.Common;

namespace Strategy.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADD...");
            var client = new CalculateClient(new StrategyPlus());
            Console.WriteLine("\n\t10 + 5 = " + client.Execute(10, 5));

            Console.WriteLine();

            Console.WriteLine("SUBSTRACT...");
            client = new CalculateClient(new StrategyMinus());
            Console.WriteLine("\n\t10 - 5 = " + client.Execute(10, 5));

            Console.WriteLine();

            Console.WriteLine("MULTIPLY...");
            client = new CalculateClient(new StrategyMultiply());
            Console.WriteLine("\n\t10 * 5 = " + client.Execute(10, 5));

            Console.WriteLine();

            Console.WriteLine("DIVIDE...");
            client = new CalculateClient(new StrategyDivide());
            Console.WriteLine("\n\t10 : 5 = " + client.Execute(10, 5));

            Console.ReadKey();
        }
    }
}
