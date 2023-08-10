using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class CheckCredit
    {
        public static void Main()
        {
            Console.WriteLine("Enter the price of purchased item:");
            int price = Convert.ToInt32(Console.ReadLine());
            if (price > 10000)
            {
                Console.WriteLine("Purchased item exceeds the amount!");
            }
            else
            {
                Console.WriteLine("Purchase Approved.");
            }
        }
    }
}
