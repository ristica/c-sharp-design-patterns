using Decorator.Common.Component;
using Decorator.Common.Decorator;

namespace Decorator.Common.ConcreteDecoator
{
    public class IceWithMandM : IceDecorator
    {
        public IceWithMandM(IceCream ic) : base(ic)
        {
            this.Cost = 1.25;
            this.Ingredients = " M&M";
        }
    }
}
