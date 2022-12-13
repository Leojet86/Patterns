using Patterns.Builder.Item.Drink;
using Patterns.Builder.Item.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    /// <summary>
    /// Builder pattern builds a complex object using simple objects and using a step by step approach.
    /// Use the Builder pattern to get rid of a “telescoping constructor”. Constructor with lots of parameters
    /// 
    /// Pro:
    ///     + Construct objects step-by-step, defer construction steps or run steps recursively
    ///     + Can reuse the same construction code when building various representations 
    ///     + Single Responsibility Principle. You can isolate complex construction code from the business logic of the product.
    /// Cons:
    ///     - The overall complexity of the code increases since the pattern requires creating multiple new classes.
    /// </summary>
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal meal = new Meal(); //complex object
            meal.AddItem(new VegyBurger()); // add item step by step
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
