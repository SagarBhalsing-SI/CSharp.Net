namespace OnlineShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            string c;
            Console.WriteLine("---------------Shopping Cart----=----------");
            Console.WriteLine("1.Add Item\n" +
                              "2.Display Cart\n");
            do
            {
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            cart.AddItem();
                            break;
                        }
                    case 2:
                        {
                            cart.DisplayCart();
                            break;
                        }
                }Console.WriteLine("Do you want to Continue:");
                 c = Console.ReadLine();
            } while (c=="Y");

        }
    }
}