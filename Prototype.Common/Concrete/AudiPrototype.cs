using Prototype.Common.Abstract;

namespace Prototype.Common.Concrete
{
    public class AudiPrototype : CarPrototype
    {
        public override CarPrototype Clone()
        {
            return (CarPrototype) this.MemberwiseClone();
        }
    }
}
