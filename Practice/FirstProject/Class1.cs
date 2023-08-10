using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
     internal class Class1
    {
        /*public Class1()
        {
            Console.WriteLine("Consructor");
        }*/
        public Class1(int i)
        {
            
            Console.WriteLine("Class1 Construtor executed"+" "+"Value of x:");
        }
        public virtual void Show()
        {
            Console.WriteLine("Parent class method");
        }
        public void Display()
        {
            Console.WriteLine("Parent class method");
        }
        /*public static void Main()
        {
            string s = "Sagar Bhalsing";
            Console.WriteLine(s.IndexOf("a"));
        }*/
    }
    class Class3:Class1 //  Child class
    {
        public override void Show() //Parent class method overrided 
        /* To override parent class method we need to have permission of parent class
         * To do that we just have to define parent method using virtual which says we can ovveride that method
         * Syntax will be like "public virtual void MethodName(){}" for parent class and "public override void MethodName(){}" for child class */
        {
            Console.WriteLine("Child class method");
        }

        public new void Display() //Same method like paren class but it is not actually overriden.
        /*This is actually called method hiding or method shadowing*/
        {
            Console.WriteLine("Child class method");
        }
        static void Main()
        {
            Class3 obj =new Class3();
            obj.Show();
            Console.ReadLine(); 
        }
    }
}
/*
*/