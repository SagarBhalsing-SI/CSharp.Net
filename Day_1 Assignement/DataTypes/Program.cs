namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char toContinue;
            Console.WriteLine("---Hello Welcome to Strom Inn---");
            Console.WriteLine("--------Menu--------");
            Console.WriteLine("--What would you like to have?");
            Console.WriteLine("1.Breakfast");
            Console.WriteLine("2.Lunch");
            Console.WriteLine("3.Dinner");
            Console.WriteLine("4.Desert");
            Console.WriteLine("5.Starters");
            Console.WriteLine("6.Exit");

            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1.Chesee Toast");
                        Console.WriteLine("2.Idli Dosa");
                        Console.WriteLine("3.Bread Butter");
                        Console.WriteLine("4.Tea");

                        break;
                    case 2:
                        Console.WriteLine("Chicken Chingari");
                        break;
                    case 3:
                        Console.WriteLine("Chicken Murgmaslam");
                        break;
                    case 4:
                        Console.WriteLine("Ice cream");
                        break;
                    case 5:
                        Console.WriteLine("Crispy");
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        break;
                }
                Console.WriteLine("Do You want anything more?");
                toContinue = Convert.ToChar(Console.ReadLine());

            } while (toContinue == 'y');


            }
    }
    }
