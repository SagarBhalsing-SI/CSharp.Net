using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

internal class Program
{
    int i; bool b; string s; int x;
    static int a; // static variables or feild can only be initialsed by static constructors
    public Program() // Implicit Default Constructor (This can also be called as non-static constructor)
    {
        Console.WriteLine("Default or Non-Static Constructor Block");
    }
    static Program() // Static Constructor (First Block of code to run under a class) It only executes 1 time
    {
        //Console.WriteLine("First to execute is always static method if present");
        Console.WriteLine("Static Constructor Block");
    }
    public Program(int i) // Parametrized Constructor
    {
        this.i = i;

    }
    public Program(Program obj) // Copy Constructor 
    {
        x = obj.x;
    }
    public void Display()
    {
        Console.WriteLine("Value of x :" + x);
    }
    private static void Main(string[] args)
    {
        /*Program p1 = new Program(10);
        Console.WriteLine(p1);
        p1.Display();
        Program p2 = new Program(p1); // This example of how copy constructor works.
        p2.Display();*/

        /* Console.ReadLine(); / So here if we just right this or just keep the main block blank
                             * only the static method will be called. 
                             *Meaning we don't need instance of class to call static method it is implicitly called */


        /*Program p = new Program();
        Console.WriteLine("Main method Block");*/

        Program obj1 = new Program(100);
        Program obj2 = new Program(200);
        Console.WriteLine(obj1.i + " " + obj2.i); /*To call the value of variables 
                                                   * inside a constructor or method we can use "object.variable" */


    }
}
