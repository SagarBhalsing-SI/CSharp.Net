using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Apartment
    {
        public static string address { get; set; }
        public string ownerName { get; set; }
        public int apartmentNo { get; set; }
        public static int noOfHouseBought { get; set; }

        public Apartment(string ownerName,int apartementNo) 
        {
            this.ownerName = ownerName;
            this.apartmentNo = apartementNo;
            ++noOfHouseBought;
        }

        public void Display()
        {
            Console.WriteLine($"OwnerName is {ownerName} and Apartement No. is {apartmentNo}");
        }

        public static void DisplayAddress()
        {
            Console.WriteLine($"Address is {address}");
        }
        public static void DisplaynoOfHouseBought()
        {
            Console.WriteLine($"No. of Apartment bought is : {noOfHouseBought}");
        }
    }
}
