using System;
using ChainOfResponsibility.Common.MessageHandler;

namespace ChainOfResponsibility.Common.Helpers
{
    class EndOfChainHandler : IMessageHandler
    {
        private EndOfChainHandler() { }

        public static EndOfChainHandler Instance
        {
            get { return _instance; }
        }

        public HandlerResponse Check(ICheckReport checkReport)
        {
            return HandlerResponse.Denied;
        }

        public void RegisterNext(IMessageHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }

        private static readonly EndOfChainHandler _instance = new EndOfChainHandler();
    }
}
