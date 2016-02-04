namespace Strategy.Common
{
    public class StrategyMinus : IStrategy
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
