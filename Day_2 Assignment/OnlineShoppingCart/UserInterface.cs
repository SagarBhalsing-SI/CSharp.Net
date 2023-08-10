using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    internal class UserInterface
    {
        public int getPrice()
        {
            Console.WriteLine("Enter Price:");
            int price = Convert.ToInt32(Console.ReadLine());
            return price;
        }
        public string getProductName()
        {
            Console.WriteLine("Enter Product Name:");
            string productName = Console.ReadLine();
            return productName;
        }
        public int getQuantity()
        {
            Console.WriteLine("Enter Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            return quantity;
        }
        


    }
}
