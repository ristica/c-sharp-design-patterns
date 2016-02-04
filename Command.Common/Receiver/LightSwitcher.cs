using System;

namespace Command.Common.Receiver
{
    public class LightSwitcher : ISwitchable
    {
        public void PowerOn()
        {
            Console.WriteLine("The light is ON");
        }

        public void PowerOff()
        {
            Console.WriteLine("The light is OFF");
        }
    }
}
