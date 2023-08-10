using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Pay_Slip
    {
        public static void Main()
        {
            int hours;
            int rate;
            Console.WriteLine("Enter the number of hours worked.");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate per hour.");
            rate = Convert.ToInt32(Console.ReadLine());
            int natInsu = (hours*rate)*5/100;
            int gross = hours * rate;
            int incomeTax = 20 * (((hours * rate) - natInsu) / 100);
            int total = hours + rate + gross + natInsu + incomeTax;
            Console.WriteLine("-----------------PAYSLIP-----------------");
            Console.WriteLine("=========================================");
           
            Console.WriteLine("Hours Worked"+"          "+hours);
            Console.WriteLine("Hourly Rate"+"           "+rate);
            Console.WriteLine("Gross Pay"  +"             "+gross);
            Console.WriteLine("National Insurance"+"    "+natInsu);
            Console.WriteLine("Income Tax"+ "            "+incomeTax);
            Console.WriteLine("=========================================");
            Console.WriteLine("Nett Pay"+"              " +total);


        }
    }
}
