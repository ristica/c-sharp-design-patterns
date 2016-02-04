using Builder.Common.Product;

namespace Builder.Common.AbstractProductBuilder
{
    public interface ICarBuilder
    {
        void SetName(string name);
        void SetWheelsCount(int count);
        void SetColour(string colour);
        void SetMaxSpeed(int speed);

        Car GetResult();
    }
}
