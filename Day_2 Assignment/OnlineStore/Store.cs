using OnlineStore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Store
    {
        List<Product> productList = new List<Product>()
        {
            new Product(){productName="Shoes",price=1500,stock=50,category="Fashion"},
            new Product(){productName="Shirt",price=1000,stock=100,category="Clothing"},
            new Product(){productName="Pant",price=1200,stock=20,category="Clothing"},
        };
        Product p = new Product();
        UserInterface ui = new UserInterface();
        int totalValue;

        public void AddProduct()
        {
            p.productName=ui.getProductName();
            p.price=ui.getPrice();
            p.category=ui.getCategory();
            p.stock=ui.getStock();  
            productList.Add(p);
        }

        public void DisplayProduct()
        {
            foreach (Product i in productList)
            {
                Console.WriteLine(i);
                totalValue =totalValue+ (i.price * i.stock);                                                                                       ;
                
            }
            Console.WriteLine("===============================================");
            Console.WriteLine($"Total Cost of all Products in stock is: {totalValue}");
        }
    }
}
