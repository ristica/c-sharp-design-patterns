using System;
using Proxy.Common.Object;
using Proxy.Common.Proxy;
using Proxy.Common.Subject;

namespace Proxy.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            ICar proxy = new CarProxy(new Driver{ Age = 17 });
            Console.Write("Driver is 17 years old => ");
            proxy.Drive();

            Console.WriteLine();
            Console.WriteLine();

            proxy = new CarProxy(new Driver{ Age = 25 });
            Console.Write("Driver is 25 years old => ");
            proxy.Drive();
            Console.WriteLine();

            Console.WriteLine(Console.ReadKey());
        }
    }
}
