using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool isRounded)
        {
            if(isRounded)
                return new RoundShapeFactory();
            else
                return new ShapeFactory();
        }
    }
}
