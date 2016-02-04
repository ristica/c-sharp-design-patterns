using System;
using Command.Common.Abstraction;
using Command.Common.Implementations;
using Command.Common.Invoker;
using Command.Common.Receiver;

namespace Command.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwitchable switcher = new LightSwitcher();

            ICommand on = new PowerOnCommand(switcher); 
            ICommand off = new PowerOffCommand(switcher);

            var invoker = new SwitchInvoker(on, off);

            Console.WriteLine("Lights ON =>");
            invoker.LightOn();
            Console.WriteLine();
            Console.WriteLine("Lights OFF =>");
            invoker.LightOff();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
