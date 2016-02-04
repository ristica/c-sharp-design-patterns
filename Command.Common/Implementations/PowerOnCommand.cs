using Command.Common.Abstraction;
using Command.Common.Receiver;

namespace Command.Common.Implementations
{
    public class PowerOnCommand : ICommand
    {
        private readonly ISwitchable _switcher;

        public PowerOnCommand(ISwitchable switcher)
        {
            this._switcher = switcher;
        }

        public void Execute()
        {
            this._switcher.PowerOn();
        }
    }
}
