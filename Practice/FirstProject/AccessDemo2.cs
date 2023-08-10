using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class AccessDemo2:AccessDemo1 //AccessDemo2 is child class of AccessDemo1
    {
        static void Main()
        {
            AccessDemo2 obj = new AccessDemo2();
            obj.Test5();obj.Test3();obj.Test2();obj.Test4();
            /* So as we can see here only public,protected,internal and protected internal methods 
             * can be accessed by different class
             * From this we understand the scope of private methods*/
        }
    }
}
