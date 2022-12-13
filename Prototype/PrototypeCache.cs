using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class PrototypeCache
    {
        //
        private static Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

        public static IShape GetShape(string id)
        {
            IShape shape = (IShape) _shapes[id].Clone();

            return shape;
        }

        // Long processing method
        public static void LoadCache()
        {
            // Query DB and load the shapes dictionary

            // for each data returned by the query
            // New shape with data from db...
            IShape shape = new Rectangle { Id = "some known guid", Type="Rectangle" };
            _shapes.Add(shape.Id, shape);
        }
    }
}
