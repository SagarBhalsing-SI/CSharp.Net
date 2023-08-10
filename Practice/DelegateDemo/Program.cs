using static DelegateDemo.Program;

namespace DelegateDemo
{

    internal class Program
    {//Signature consist of order of arguments or dataypes and also return type
        //Step 1: Decalre a Delegate
        delegate void GreetingsDelegate(string str);
        //delegate void PerformCalculation(int x, int y);
        public delegate T PerformanceCalculation <T>(T x,T y);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            String str = Console.ReadLine();
            Console.WriteLine("Enter Integer");
            int x = Convert.ToInt32(Console.ReadLine());    
            int y = Convert.ToInt32(Console.ReadLine());

            Calculator calc = new Calculator();
            PerformanceCalculation <int>cal = null;
            PerformanceCalculation<string> cal1 = calc.Line;

            if (str == "+")
            {
                cal = calc.Add;
                cal(x, y);
            }
            else if (str == "-") 
            {
                cal = calc.Sub;
                cal(x, y);

            }
            else if(str == "*") 
            {
                cal = calc.Mul;
                cal(x, y);

            }
            else if( str == "/") 
            {
                cal = calc.Div;
                cal(x, y);


            }
            /*Console.WriteLine("Enter message:");
            string msg=Console.ReadLine();
            //Step 2 : Create a Instance for delegate and bind method with same signature 
            GreetingsDelegate greet = DisplayWelcome;
            //Step 3 : Call the delegate by passing parameter if nay 
            greet("Sagar");
            //Multicast Delegate
            greet += DisplayThankyou;
            //Remove method from delegate
            greet -= DisplayThankyou;

            GreetingsDelegate greetingsDelegate = DisplayThankyou;
            greetingsDelegate("Anchal");*/
        }
        static int DisplayResult(int x, int y ,PerformCalculation cal)
        {
            int result = cal(x, y);
            Console.WriteLine($"The result is: {result}");

        }
        static void DisplayWelcome(string message)
        {
            Console.WriteLine($"Hello {message}");
        }

        static void DisplayThankyou(string message)
        {
            Console.WriteLine($"Welcom {message}");
        }
    }
}