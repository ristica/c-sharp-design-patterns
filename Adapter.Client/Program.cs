using System;
using System.Collections.Generic;
using Adapter.Common.Adaptor;
using Adapter.Model;

namespace Adapter.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            IEmployeeAdaptor adaptor = new EmployeeAdaptor();
            List<NewEmployee> newEmployees = adaptor.GetAdaptedEmployees();

            foreach (var e in newEmployees)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(e.Address);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
