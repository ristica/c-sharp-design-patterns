namespace ChainOfResponsibility.Common.Helpers
{
    public interface IMessageChecker
    {
        string Name { get; }
        HandlerResponse CheckReport(ICheckReport report);
    }
}
