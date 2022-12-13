using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Builder.Item.Packaging;

namespace Patterns.Builder.Item.Food
{
    public class VegyBurger : Burger
    {
        public override string Name
        {
            get => "Vegy Burger";
        }
        public override IPacking Packing
        {
            get => new PaperWrap();
        }
        public override double Price
        {
            get => 3.45;
        }
    }
}
