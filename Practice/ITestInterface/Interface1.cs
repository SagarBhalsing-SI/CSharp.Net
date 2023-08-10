using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITestInterface
{
    internal interface Interface1 //This is interface
    {
        /* In interface we cannot decalre any variables and fields
         * Every member of interface are by purely abstract 
         * In abstract class there can be both abstrat and non-absract class but only abstract in Interfaces.
         */
        void Add (int x, int y);    //Here by deafult these interfaces are public
        
    }

    interface Interface2 : Interface1 //So here as we can see we can inherit from other interfaces.
    {
        void Sub (int x, int y);
        public static int multiply(int x = 10, int y = 2)
        {
            return x * y;
        }


    }
    class Implementation : Interface2//So here Implementation is a child class for the interface2
    {
        /*Things to note is that we should always implement the interface fields or members in child class without fail or it will show error*/
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        /* Here we have manually said the method is public because in class by default a method is private and 
         * but we are inhereting these methods from class where by default methods are public not private
         * So if we make methods here private it will so error*/

        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Main()
        {
            Implementation I = new Implementation();
            I.Sub (100, 20);
            I.Add (60, 20);
           
        }
    }
}
 