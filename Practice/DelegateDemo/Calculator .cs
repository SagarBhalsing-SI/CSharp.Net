using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Calculator
    {
        public int x { get; set; }
        public int y { get; set; }
   
        public string Line(string x,string y)
        {
            return $"{x}";
        }
        public int Add(int x, int y)
        {
            //Console.WriteLine($"Addition of {x} and {y} is :{x+y}");
            return x + y;
        }
        public int Sub(int x, int y) 
        {
            // Console.WriteLine($"Subtraction of {x} and {y} is :{x - y}");
            return x - y;
        }

        public int  Mul(int x, int y)
        {
            //Console.WriteLine($"Multiplication of {x} and {y} is :{x * y}");
            return x *y;
        }

        public int Div(int x, int y)
        {
            return x / y;
            /*try
            {
                //Console.WriteLine($"Division of {x} and {y} is :{x /y}");
                return x / y;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine("Please Enter valid value");
            }*/

        }
    }
}
