using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Singletone.Common;

namespace Singletone.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = Car.GetInstance();

            Console.ReadKey();
        }
    }
}
