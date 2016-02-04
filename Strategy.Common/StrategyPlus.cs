namespace Strategy.Common
{
    public class StrategyPlus : IStrategy
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
