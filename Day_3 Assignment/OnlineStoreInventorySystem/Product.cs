using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OnlineStoreInventorySystem
{
    internal class Product
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
        public int productStock { get; set; }
        public int productId { get; set; }

        public override string ToString()
        {
            return $"Product Id:{productId}   Product:{productName}  Price:{productPrice}  Stock:{productStock}  ";
        }
    }
    class Electronics : Product
    { 
        public string productBrand { get; set; }
        public override string ToString()
        {
            return $"Product Id:{productId}   Product:{productName}  Price:{productPrice}  Stock:{productStock} Product Brand:{productBrand} ";
        }
    }
    class Clothing : Product
    {
        public double clothSize { get; set; }
        public override string ToString()
        {
            return $"Product Id:{productId}   Product:{productName}  Price:{productPrice}  Stock:{productStock} Cloth Size:{clothSize} ";
        }
    }

    class Books : Product
    {
        public string authorName { get; set; }
        public override string ToString()
        {
            return $"Product Id:{productId}   Product:{productName}  Price:{productPrice}  Stock:{productStock}  Author Name:{authorName} ";
        }
    }
}
