namespace ChainOfResponsibility.Common.Helpers
{
    public class CheckReport : ICheckReport
    {
        public CheckReport(int total)
        {
            this.Total = total;
        }

        public int Total { get; }
    }
}
