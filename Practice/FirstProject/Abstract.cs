namespace FirstProject
{
    internal class Abstract
    {
        public abstract class Parameters
        {
            public double width, lenght,  height,  radius;
            public const double Pi = 3.14159;
            public abstract double GetArea();

        }
        public class Rectangle:Parameters
        {
            public Rectangle(double lenght, double height)
            {
                this.lenght=lenght; this.height=height;
            }
            public override double GetArea()
            {
                return lenght * height;
            }
        }
        public static void Main()
        {
            Rectangle r = new Rectangle(332,2323);
        }
    }
}
 
