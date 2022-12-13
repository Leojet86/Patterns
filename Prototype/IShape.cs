using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public interface IShape : ICloneable
    {
        public string Id { get; set; }
        public string Type { get; set; } //triangle, cercle and stuff...


        /// <summary>
        /// Prototype pattern refers to creating duplicate object
        /// his pattern involves implementing a prototype interface which tells to create a clone of the current object. 
        /// 
        /// This pattern is used when creation of object directly is costly. 
        /// For example, an object is to be created after a costly database operation. 
        /// We can cache the object, returns its clone on next request and update the database 
        /// as and when needed thus reducing database calls.
        /// </summary>
        public object Clone();

        public void DrawShape();

    }

    public class Rectangle : IShape
    {
        public string Id { get; set; }
        public string Type { get; set; }

        public object Clone()
        {
            IShape clone = null;

            try
            {
                // Do Deep copy of object
                clone = this; //for example only, this =/= deep copy
            }
            catch
            {
                // log error
            }

            return clone;
        }

        public void DrawShape()
        {
            Console.WriteLine("Drawing a rectangle yay");
        }
    }
}
