namespace Prototype.Common.Abstract
{
    public abstract class CarPrototype
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool AutomaticGear { get; set; }

        protected CarPrototype()
        {
            this.Name = "A8";
            this.MaxSpeed = 280;
            this.AutomaticGear = false;
        }

        public abstract CarPrototype Clone();
    }
}
