namespace ShapeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.CalculateArea();  
            rectangle.CalculatePerimeter();

            Triangle triangle = new Triangle();
            triangle.CalculateArea();
            triangle.CalculatePerimeter();

            Circle circle = new Circle();
            circle.CalculateArea();
            circle.CalculatePerimeter();

        }
    }
}