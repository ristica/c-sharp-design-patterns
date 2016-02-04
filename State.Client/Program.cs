using System;
using State.Common;

namespace State.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StateContext(new StartState());

            Console.WriteLine("##########################");
            Console.WriteLine();

            context.RequestStateChange();
            context.RequestStateChange();
            context.RequestStateChange();
            context.RequestStateChange();

            Console.WriteLine();
            Console.WriteLine("##########################");

            Console.ReadKey();
        }
    }
}
