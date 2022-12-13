using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Builder.Item.Packaging;

namespace Patterns.Builder.Item.Food
{
    public interface IFoodItem
    {
        public string Name { get; }
        public IPacking Packing { get; }
        public double Price { get; }
    }
}
