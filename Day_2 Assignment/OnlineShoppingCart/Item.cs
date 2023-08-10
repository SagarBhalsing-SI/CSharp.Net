using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    internal class Item
    {
        public string productName { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        public int totalPrice { get { return totalPrice; }
            set
            {
                totalPrice = price*quantity;
            } 
        }



        public override string ToString()
        {
            return $"Product: {productName}  Price:{price}  Quantity:{quantity} Total Price:{totalPrice}";        }
    }
}
