namespace Linq
{
    internal class Program
    {
        public  static  void Linq1()
        {
            int[] number = new int[] { 1, 2, 3,4,5,6,7,8,21,56,78,34,21,32,67,89,90 };
            //var result = from num in number where num>4 orderby num select num;//Query Syntax
            
            var result = number.Where(x=>x>10).OrderBy(x => -x).Distinct();//Method Syntax
            foreach(var item in result )
            {
                Console.WriteLine( item +"\t");
            }
            Console.WriteLine();
        }

        public static void Linq2()
        {
            var number = from num in Enumerable.Range(0, 20)
                         select new { Number = num, OddEven = num % 2 == 0 ? "Even" : "Odd" };

            foreach (var item in number)
            {
                Console.WriteLine( item +"\t");
            }



        }
        public static void Linq3()
        {
            string[] fruits = { "APPLE" };
            var RE
        }
        static void Main(string[] args)
        {
            //Linq1();
            Linq2();
            Console.ReadKey();
        }
    }
}