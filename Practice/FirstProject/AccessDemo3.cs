using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class AccessDemo3
    {
        public static void Main()
        {
            AccessDemo1 demo = new AccessDemo1();
            demo.Test2();demo.Test4();demo.Test5();
            /* Here as we can see we can access public ,internal and protected internal 
             * methods of different class just by making instance of that class in other class
             * But as we can observe protected method is not avaiable for any class other than child class
             * So the scope of protected method is child class  
             */
        }
    }
}
