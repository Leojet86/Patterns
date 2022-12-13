using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Builder.Item.Food;
using Patterns.Builder.Item.Packaging;

namespace Patterns.Builder.Item.Drink
{
    public abstract class ColdDrink : IFoodItem
    {
        public abstract string Name { get; }
        public abstract IPacking Packing { get; }
        public abstract double Price { get; }
    }
}
