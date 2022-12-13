using Patterns.Builder.Item.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class Meal
    {
        private List<IFoodItem> items = new List<IFoodItem>();

        public void AddItem(IFoodItem item)
        {
            items.Add(item);
        }

        public double GetCost()
        {
            double cost = 0;
            foreach (var item in items)
            {
                cost += item.Price;
            }

            return cost;
        }


        public void ShowMeal()
        {
            foreach (var item in items)
            {
                Console.Write("Item : " + item.Name);
                Console.Write(", Packing : " + item.Packing.Pack());
                Console.WriteLine(", Price : " + item.Price);
            }
        }
    }
}
