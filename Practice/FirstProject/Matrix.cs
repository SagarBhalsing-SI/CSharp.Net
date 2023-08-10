/* In this we will se how to actualy overload and operator i.e; +,-,> and etc.
 * The acual syntax for addition operation in backend is like this -"public static int operator +(int a, int b)" similarly for different operators.
 * So the syntax to implement operator overlaoding is as follows:
 * [<access modifier>] static <return type> operator <opt>
 * Example- public static void name +(){}
 * */

//For more clarification on this wach video no.16 Polymorphism in C# Operator Overloading | C#.NET Tutorial | Mr. Bangar Raju

namespace FirstProject
{
    internal class Matrix
    {
        int a; int b; int c; int d;
        public Matrix(int a, int b, int c, int d) //constructor to take values for matrix.
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }

        public override string ToString() //Overriden method to get Martix Output.
        {
            return (a + " " + b + "\n" + c + " " + d + "\n");
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2) //Method overlaoding of + operator to add Matrix.
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        /* So here as we can see the return type for above method is Matrix which we have defined.
         * So here we instance of class matrix and pass on the arguments to the constructor for addition
         * And return the matrix
         * Similar approach for below method*/

        public static Matrix operator -(Matrix obj1, Matrix obj2) //We might have confusion here that what is that Matrix obj1 so its actully a datatyppe tha we have defined.
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }

    }
    class TestMatrix
    {
        static void Main()
        {
            Matrix m1 = new Matrix(10, 20, 30, 40);
            Matrix m2 = new Matrix(15, 25, 35, 45);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;

            Console.WriteLine(m1);//WriteLine is an overloaded method it can take upto 19 different paraemters we can this by moving cursor on it 
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            /*So we can pass 19 differen parameter like int string to this WriteLine method but here we have passed
             * an object here which is m1,m2m3 and m4.
             * So in backend what happens is that WriteLine takes the paramter object i looks like :
             * public static void WriteLine(Object Value)
             * {
             * sting Typename = value.ToString(); //This ToString() method is default method availabe along with other 3 methods for any class.
             * }
             *
             * So what happens here is that in backend method returns the type of object so here the 
             * type is Matrix that we have defined above m1,m2,m3 and m4 are all Type Matrix.
             * So Due to this when we pass m1,m2,m3 and m4 o writeline we get the type of object in return.
             * But here we wanted to get matrix as an output.
             * To get that we have to oveeride the inbuilt method of ToString()
             * If we overide that method here i will be applicable to the whole class
             * You can see that in above code.
             */
            Console.ReadLine();
        }
    }
}
