namespace LSP
{
    /// <summary>
    /// The Liskov Substitution Principle (LSP) is one of the SOLID principles, 
    /// emphasizing that objects of a base class should be 
    /// replaceable with objects of a derived class
    /// without affecting the correctness of the program.
    /// 
    /// </summary>
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw shape");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
    internal class Program
    {
        static void Main()
        {
            // Using LSP: treating derived class as base class
            Shape shape2 = new Circle();
            shape2.Draw(); // This should call the overridden method in Circle
            // Using LSP: treating derived class as base class
            Circle circle = new Circle();
            circle.Draw(); // This should call the overridden method in Circle

            Shape shapeCirecle = circle;
        }
    }

}