using System.Runtime.InteropServices;

namespace ChainOfResponsibility.Common.Helpers
{
    public class Checker : IMessageChecker
    {
        public string Name { get; private set; }
        private readonly int _total;

        public Checker(string name, int total)
        {
            this.Name = name;
            this._total = total;
        }

        public HandlerResponse CheckReport(ICheckReport report)
        {
            return report.Total > this._total
                ? HandlerResponse.NotApprovable
                : HandlerResponse.Approved;
        }
    }
}
