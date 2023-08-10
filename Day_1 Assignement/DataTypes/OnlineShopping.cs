using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class OnlineShopping
    {    public static void Main()
        {
            int price;
            string choice;
            int total=0;
            Console.WriteLine("Welcome To our Shop.");
            
            do
            {
                Console.WriteLine("Enter your the price of Your clothes");
                price = Convert.ToInt32(Console.ReadLine());
                total += price;
                Console.WriteLine("Do you want to add more");
                choice = Console.ReadLine();

            } while (choice == "yes");
            double Total = total + (total * 0.05);
            Console.WriteLine("Your total price is "+ " "+Total);
        }

    }
}
