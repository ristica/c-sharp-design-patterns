using Decorator.Common.Component;
using Decorator.Common.Decorator;

namespace Decorator.Common.ConcreteDecoator
{
    public class IceWithChocolateSauce : IceDecorator
    {
        public IceWithChocolateSauce(IceCream ic) : base(ic)
        {
            this.Cost = 0.75;
            this.Ingredients = "chocolate sauce";
        }
    }
}
