namespace MethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double grossPay;
            double netPay = CalculateSalary(5000,2000,out  grossPay);
            Console.WriteLine($"NetPay:{netPay} and GrossPay:{grossPay}");
           /* Calculator calc = new Calculator();
            Console.WriteLine(calc.addInt(90, 10));
            Console.WriteLine(calc.multiplyInt(2, 10));
            calc.swap(10, 20);

            int a = 10;
            int b = 20;
            Console.WriteLine("\n");
            Console.WriteLine($"Before a:{a} and b:{b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After a:{a} and b:{b}");*/
        }
        static double CalculateSalary(double bPay,double allownaces, out double grossPay )
        {
            grossPay = bPay + allownaces;
            double netPay = bPay - (bPay * 0.30);
            return netPay;
        }




        static void Swap(ref int x, ref int y)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine($"Before a:{x} and b:{y}");
            int temp;
            temp = x;
            x = y;  
            y = temp;
            Console.WriteLine($"After a:{x} and b:{y}");
            Console.WriteLine("====================================================");

        }
    }
}