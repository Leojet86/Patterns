namespace Patterns.Factory
{
    //Concrete classes - usually in separate files, but here for simplicity purposes
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
