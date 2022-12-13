using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Builder.Item.Packaging;

namespace Patterns.Builder.Item.Drink
{
    public class Coke : ColdDrink
    {
        public override string Name
        {
            get => "Coke";
        }
        public override IPacking Packing
        {
            get => new Bottle();
        }
        public override double Price
        {
            get => 2.00;
        }
    }
}
