using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    internal class NamedParameter
    {
        public void Display(string name,double size,int age = 10)
        {
            Console.WriteLine(name+" "+size+" "+age);
        }

        public void Shopping(string name,params int[] shopList)
        {
            int Total = 0;
            for (int i = 0; i < shopList.Length; i++)
            {
                Total += shopList[i];
            }
            Console.WriteLine($"The total amount is :{Total}");
        }
        public static void Main()
        {
            NamedParameter n = new NamedParameter();
            n.Display("Sagar", size:34.2);
            n.Shopping("Sagar",20,100,140,100,303);
        }
    }
}
