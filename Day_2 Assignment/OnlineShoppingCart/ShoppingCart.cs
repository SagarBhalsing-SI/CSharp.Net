using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    internal class ShoppingCart
    {
        List<Item> Cart = new List<Item>()
        {
            new Item(){productName="Shoes", price=1500,quantity=2},
        };
        UserInterface ui = new UserInterface();
        int cartPrice;
        public void AddItem()
        {
            Item i = new Item();
            i.productName = ui.getProductName();
            i.price = ui.getPrice();
            i.quantity = ui.getQuantity();

            Cart.Add(i);

        }
        public void DisplayCart()
        {
            
            foreach (Item i in Cart)
            {
                Console.WriteLine(i);
                cartPrice += i.totalPrice;
            }
            Console.WriteLine("===============================================");
            Console.WriteLine($"Total Cost of all Items is: {cartPrice}");
        }
    }
}
