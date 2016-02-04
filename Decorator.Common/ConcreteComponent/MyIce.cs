using System;
using Decorator.Common.Component;

namespace Decorator.Common.ConcreteComponent
{
    public class MyIce : IceCream
    {
        public override double GetCost()
        {
            return 1.00;
        }

        public override string GetIngredients()
        {
            return "Ice with";
        }
    }
}
