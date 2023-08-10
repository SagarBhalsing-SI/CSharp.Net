/* There 5 different Access Modifiers in C# namely
 * private , internal , protected , protected internal ,public
 * Every method is accesible in the same class there are no restrictions
 * We can only use public and internal as access modifier for Class */
namespace FirstProject
{
    internal class AccessDemo1
    {
        private void Test1()//Method only accessible in class which it was defined in. 
        {
            Console.WriteLine("Private Method");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method");
        }

        static void Main()
        {
            AccessDemo1 obj = new AccessDemo1();
            obj.Test1(); obj.Test2(); obj.Test3(); obj.Test4(); obj.Test5();
        }
    }
}
