namespace OnlineStoreInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics electronics = new Electronics();
            electronics.productId = 1;
            electronics.productName = "Smart Phone";
            electronics.productPrice = 20000;
            electronics.productStock = 10;
            electronics.productBrand = "Samsung";
            Console.WriteLine(electronics);
            Console.WriteLine("\n");

            Clothing clothing = new Clothing();
            clothing.productId = 2;
            clothing.productName = "Shirt";
            clothing.productPrice = 1500;
            clothing.productStock = 20;
            clothing.clothSize = 42;
            Console.WriteLine(clothing);
            Console.WriteLine("\n");

            Books books = new Books();
            books.productId = 3;
            books.productName = "Tales of Demons and Gods";
            books.productPrice = 1200;
            books.productStock = 50;
            books.authorName = "Tite Kubo";
            Console.WriteLine(books);

        }
    }
}