using Builder.Common.AbstractProductBuilder;
using Builder.Common.Product;

namespace Builder.Common.ProductBuilder
{
    public class CarBuilder : ICarBuilder
    {
        private readonly Car _car;

        public CarBuilder()
        {
            this._car = new Car();
        }

        public void SetName(string name)
        {
            this._car.Name = name;
        }

        public void SetWheelsCount(int count)
        {
            this._car.Wheels = count;
        }

        public void SetColour(string colour)
        {
            this._car.Colour = colour;
        }

        public void SetMaxSpeed(int speed)
        {
            this._car.Speed = speed;
        }

        public Car GetResult()
        {
            return this._car;
        }
    }
}
