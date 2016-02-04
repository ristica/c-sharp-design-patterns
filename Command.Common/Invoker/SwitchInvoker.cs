using Command.Common.Abstraction;

namespace Command.Common.Invoker
{
    public class SwitchInvoker
    {
        private readonly ICommand _onCommand;
        private readonly ICommand _offCommand;

        public SwitchInvoker(ICommand onCommand, ICommand offCommand)
        {
            this._onCommand = onCommand;
            this._offCommand = offCommand;
        }

        public void LightOn()
        {
            this._onCommand.Execute();
        }

        public void LightOff()
        {
            this._offCommand.Execute();
        }
    }
}
