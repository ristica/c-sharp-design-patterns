namespace Strategy.Common
{
    public class StrategyMultiply : IStrategy
    {
        public int Calculate(int a, int b)
        {
            return a*b;
        }
    }
}
