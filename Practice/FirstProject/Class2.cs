using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Class2:Class1
    {
        public Class2():base(90)
        {
            Console.WriteLine("Child Class");
        }
        static void Main()
        {
            Object obj = new Object();
            /* Every class we define is actually a child class of a pre-defined root class that is know as Object class
             * Object class has 4 member which every instance can access*/
            //obj.ToString();obj.Equals(null);obj.GetType();obj.GetHashCode();    //These are four pre-defined members of Object class
            Class2 c = new Class2();    
            
        }
    }
}
/* Things to note in inheritence is that a parent class construtor should always be 
 * public because as we know all the variables of a clas is intiliased by contructor 
 * of a class so if parent has have any variable it should make its construtor public so
 * that the child class can access the variables of parent class */

/* Till now parent class construtor was parameterless but if we make it parameterized 
 * the child class which is inhereting the parent class need to explicitlty pass a parameter using "base()" keyword
 * As we know the child class accesses the parent class member by going through its own constructor we can visualize this by having
 * breakpoint on where object of child class was created.
 * So to solve this issue we need to pass paramter from child class from he constructor
 * Construtor of child class --->" public childclass():base(parameter){} "*/

