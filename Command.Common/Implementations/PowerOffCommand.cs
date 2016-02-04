using Command.Common.Abstraction;
using Command.Common.Receiver;

namespace Command.Common.Implementations
{
    public class PowerOffCommand : ICommand
    {
        private readonly ISwitchable _switcher;

        public PowerOffCommand(ISwitchable switcher)
        {
            this._switcher = switcher;
        }

        public void Execute()
        {
            this._switcher.PowerOff();
        }
    }
}
