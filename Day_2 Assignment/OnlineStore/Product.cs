using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Product
    {
        public string productName { get; set; }
        public int price { get; set; }
        public int stock { get; set; }  
        public string category { get; set; }

        public override string ToString()
        {
            return $"Product:{productName}  Price:{price}  Stock:{stock}  Category:{category}";
        }
    }
}

