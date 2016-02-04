using System;
using Composite.Common.Composite;
using Composite.Common.Leaf;

namespace Composite.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var composite = new Car(); 

            var childA = new Car(); 
            var childB = new Car(); 

            childA.Add(new Audi()); // LEAF
            childB.AddRange(new Bmw(), new Gmc()); // COMPOSITION  

            composite.AddRange(childA, new Mercedes(), childB); // ROOT
            composite.Print();

            Console.ReadKey();
        }
    }
}
