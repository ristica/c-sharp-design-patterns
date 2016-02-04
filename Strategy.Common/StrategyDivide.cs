using Strategy.Common;

namespace Strategy.Common
{
    public class StrategyDivide : IStrategy
    {
        public int Calculate(int a, int b)
        {
            return a/b;
        }
    }
}
