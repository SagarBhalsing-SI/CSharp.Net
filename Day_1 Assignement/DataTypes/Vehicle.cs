using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Vehicle
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of new vehicle registration: ");
            int vehicle=Convert.ToInt32(Console.ReadLine());
            int[] regiNum = new int[vehicle]; 

            for (int i = 0; i < vehicle; i++)
            {
                
                regiNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"There total {vehicle} vehicles registered");
            Console.WriteLine(regiNum);
        }
    }
}
