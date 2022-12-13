﻿using Patterns.Factory;
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


    }


    
}