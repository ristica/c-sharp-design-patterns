namespace Strategy.Common
{
    public class CalculateClient
    {
        private readonly IStrategy _strategy;

        public CalculateClient(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public int Execute(int a, int b)
        {
            return this._strategy.Calculate(a, b);
        }
    }
}
