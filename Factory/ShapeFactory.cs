using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    /// <summary>
    /// In Factory pattern, we create object without exposing the creation 
    /// logic to the client and refer to newly created object using a common interface.
    /// </summary>
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(Shape type)
        {
            // One of the Only acceptable case where a switch case, or big if statement should be use.
            switch (type)
            {
                case Shape.Rectangle:
                    return new Rectangle();
                case Shape.Circle:
                    return new Circle();
                case Shape.Square:
                default:
                    return new Square();
            }
        }
    }
}
