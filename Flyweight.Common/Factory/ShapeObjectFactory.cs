using System;
using System.Collections.Generic;
using Flyweight.Common.ConcreteFlyweight;
using Flyweight.Common.Flyweight;

namespace Flyweight.Common.Factory
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class ShapeObjectFactory
    {
        readonly Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get { return _shapes.Count; }
        }

        public IShape GetShape(string shapeName)
        {
            IShape shape;
            if (_shapes.ContainsKey(shapeName))
            {
                shape = _shapes[shapeName];
            }
            else
            {
                switch (shapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        _shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        _shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}