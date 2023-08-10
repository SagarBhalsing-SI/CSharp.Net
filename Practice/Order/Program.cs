namespace Order
{
    internal class Program
    { 
        static void Main(string[] args)
        {

            Order r1 = new Order(110,"Sagar",10);
            Order r2 = new Order(110, "Anas", 20);

            Console.WriteLine(r1);
            Console.WriteLine(r2);


            Console.WriteLine(r1.GetHashCode());
            Console.WriteLine(r2.GetHashCode());

            Console.WriteLine(r2.Equals(r1));




        }
    }
}