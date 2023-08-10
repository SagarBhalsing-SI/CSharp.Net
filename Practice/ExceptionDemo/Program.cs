namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a/b);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Went Wrong");
               Console.WriteLine(e.Message);
            }
        }
    }
}