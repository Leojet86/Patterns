using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patterns.Factory.ShapeFactory;

namespace Patterns.Factory
{
    /// <summary>
    /// Abstract Factory patterns work around a super-factory which creates other factories. 
    /// This factory is also called a factory of factories.
    /// 
    /// factory-ception
    /// </summary>
    public abstract class AbstractFactory
    {
        public enum Shape
        {
            Rectangle,
            Circle,
            Square,
            Triangle
        }

        public abstract IShape GetShape(Shape type);
    }
}
