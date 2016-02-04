using Bridge.Common.AbstractImplementor;

namespace Bridge.Common.Abstraction
{
    //public interface IShape
    //{
    //    void Draw();
    //    void Fill();
    //}

    /// <summary>
    /// this is more dinamic then abstraction through an interface
    /// because client can dinamically change painter 
    /// and use a couple of them in it's life time
    /// and not only one instance per lifetime
    /// </summary>
    public abstract class Shape
    {
        public IPainter Painter { protected get; set; }
        public abstract void Draw();
        public abstract void Fill();
    }
}
