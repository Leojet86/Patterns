using Patterns.Builder;
using Patterns.Factory;
using Patterns.Prototype;

namespace Patterns;
class Program
{
    static void Main(string[] args)
    {
        #region Prototype Pattern
        // Test prototype Pattern
        //PrototypeCache.LoadCache();
        //IShape clonedShape = (IShape)PrototypeCache.GetShape("some known guid");

        //Console.WriteLine(clonedShape.Type); // output rectangle 
        #endregion

        #region Factory Pattern, not abstract
        //ShapeFactory shapeFactory = new ShapeFactory();

        ////get an object of Circle and call its draw method.
        //Factory.IShape shape1 = shapeFactory.GetShape(ShapeFactory.Shape.Circle);

        ////call draw method of Circle
        //shape1.Draw(); 
        #endregion

        #region Builder Pattern
        //MealBuilder mealBuilder = new MealBuilder();

        //Meal vegMeal = mealBuilder.PrepareVegMeal();
        //Console.WriteLine("Veg Meal");
        //vegMeal.ShowMeal();
        //Console.WriteLine("Total Cost: " + vegMeal.GetCost());

        //Meal nonVegMeal = mealBuilder.PrepareMeal();
        //Console.WriteLine("\n\nNon-Veg Meal");
        //nonVegMeal.ShowMeal();
        //Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());
        PersonBuilder builder = new PersonBuilder();
        Person person = builder
            .FirstName("Bob")
            .LastName("Dylan")
            //.NAS("1234567890")
            .Phone("514-937-0707")
            .Age(33)
            .Build();
        Console.WriteLine(person);
        #endregion
    }



}
