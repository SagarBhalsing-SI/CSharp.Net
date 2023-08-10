
namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store cart = new Store();
            string c;
            Console.WriteLine("---------------Shopping Cart----=----------");
            Console.WriteLine("1.Add Product\n" +
                              "2.Display Procuts\n");
            do
            {
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            cart.AddProduct();
                            break;
                        }
                    case 2:
                        {
                            cart.DisplayProduct();
                            break;
                        }
                }
                Console.WriteLine("Do you want to Continue:");
                c = Console.ReadLine();
            } while (c == "Y");

        }
    }
}