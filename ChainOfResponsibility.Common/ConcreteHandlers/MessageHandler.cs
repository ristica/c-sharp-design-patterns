using System;
using ChainOfResponsibility.Common.Helpers;
using ChainOfResponsibility.Common.MessageHandler;

namespace ChainOfResponsibility.Common.ConcreteHandlers
{
    public class MessageHandler : IMessageHandler
    {
        private readonly IMessageChecker _checker;
        private IMessageHandler _nextHandler;

        public MessageHandler(IMessageChecker checker)
        {
            this._checker = checker;
            this._nextHandler = EndOfChainHandler.Instance;
        }

        public HandlerResponse Check(ICheckReport checkReport)
        {
            var response = this._checker.CheckReport(checkReport);
            if (response == HandlerResponse.NotApprovable)
            {
                return this._nextHandler.Check(checkReport);
            }

            Console.WriteLine("checked by {0}", this._checker.Name);
            return response;
        }

        public void RegisterNext(IMessageHandler next)
        {
            this._nextHandler = next;
        }
    }
}
