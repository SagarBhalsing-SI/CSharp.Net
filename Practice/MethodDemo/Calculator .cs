using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    internal class Calculator
    {
        public int addInt(int a, int b)
        {
            int result = a + b;
            return result;
        }
        
        public int multiplyInt(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public void swap(int a, int b)
        {
            Console.WriteLine($"Before a:{a} and b:{b}");
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After a:{a} and b:{b}");
        }
    }
}
