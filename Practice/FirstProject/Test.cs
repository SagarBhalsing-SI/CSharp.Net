using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Class - User defined Data Type.
 * So we use string and int datatypes but what we don't know is that they are actually class.
 * Class is like a plan and using that plan to create a house is it's instance.
 * For example int and strings are class means ideas so if we right "int = 100 or string ="xyz" "
 * This will show error as we assiging value to a plan but if we use a instance or variable for these classes
 * like (int x = 100 or string s = "xyz" )we can use these data types
 * So whatever class we make are all user defined Data types.
 */

/* Varibales - Copy of a class that is not initialised (Test obj ,int i, string s)
 * Instances - Copy of a class initialised using "new" keyword (Test obj =new Test()) */
namespace FirstProject
{
    internal class Test
    {
        int x = 100;
        static int y = 200;
        public Test(int x) {
            this.x = x;
            
        }   
        public static void Main()
        {
            /*Console.WriteLine(x);  If we write this it will show error because 
                                    *Because a public variable cannot be called by
                                    *Static method */
            /*Console.WriteLine(y); This can be executed because we are calling 
                                    * static variable with static method */
            Test  obj = new Test(50);
            Test  obj2 = new Test(60);
            Console.WriteLine(obj.x+" "+obj2.x);

            
           /* Test obj = new Test();
            Console.WriteLine(obj.x);*/
            // So as we can see we need to create a instance of class in static main method to call the class varibale.
        }
    }
}