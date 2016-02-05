using ChainOfResponsibility.Common.Helpers;

namespace ChainOfResponsibility.Common.MessageHandler
{
    public interface IMessageHandler
    {
        HandlerResponse Check(ICheckReport checkReport);

        void RegisterNext(IMessageHandler next);
    }
}
