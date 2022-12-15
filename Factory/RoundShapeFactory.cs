using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    public class RoundShapeFactory : AbstractFactory
    {
        public override IShape GetShape(Shape type)
        {
            
            switch (type)
            {
                case Shape.Rectangle:
                    return new RoundedRectangle();
                
                case Shape.Square:
                default:
                    return new RoundedSquare();
            }
        }
    }
}
