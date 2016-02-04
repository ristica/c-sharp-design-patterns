using Decorator.Common.Component;

namespace Decorator.Common.Decorator
{
    public abstract class IceDecorator : IceCream
    {
        private readonly IceCream _ice;
        protected double Cost = 0;
        protected string Ingredients = "No igredients";

        protected IceDecorator(IceCream ice)
        {
            _ice = ice;
        }

        public override double GetCost()
        {
            return this._ice.GetCost() + this.Cost;
        }

        public override string GetIngredients()
        {
            return string.Format("{0}, {1}", this._ice.GetIngredients(), this.Ingredients);
        }
    }
}
