using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITestInterface
{   interface Interface3
    {
        void Test();
        void Show();


    }
    interface Interface4
    {
        void Test();
        void Show();

        public static int multiply(int x=10, int y=2)
        {
            return x * y;
        }
    }
    internal class MultipleInheritance : Interface3, Interface4
    {
        public void Test() //This is normal implementation of Interface method.
        {
            Console.WriteLine("Implemented both Interface method in a single Implementation");
            //Here Both interfaces have no idea about each other so there isn't any error if we implement same method ones
            //Both the Interfaces think that there method is implemented 
        }
        
        //If we want to refer to the specific interface member we can use below syntax.
        void Interface3.Show() /* Explicit Implementation of Interfce members. This is also another way to imolement interface members or fields 
                                * Here even if we don't write public access modifier its fine because 
                                * we are directly referring to the Interace using the "Interface.member or feild" syntax.*/
        {
            Console.WriteLine("Implemenation of Interface3 Method seprately");
        }
        void Interface4.Show() 
        {
            Console.WriteLine("Implemenation of Interface4 Method seprately");
        }
        
    }
}
