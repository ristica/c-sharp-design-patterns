using Decorator.Common.Component;
using Decorator.Common.Decorator;

namespace Decorator.Common.ConcreteDecoator
{
    public class IceWithSprinkles : IceDecorator
    {
        public IceWithSprinkles(IceCream ic) : base(ic)
        {
            this.Cost = 0.25;
            this.Ingredients = "sprinkles";
        }
    }
}
