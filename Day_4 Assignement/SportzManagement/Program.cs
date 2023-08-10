using System.Transactions;

namespace SportzManagement
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            string c;
            UI uI = new UI();
            do
            {
                Console.WriteLine("Select Menu: ");
                Console.WriteLine("1.Athlete Menu\n" +
                                  "2.Event Menu\n" +
                                  "3.Performance Menu\n");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            uI.AthleteUI();
                            break;
                        }
                    case 2:
                        {
                            uI.EventUI();
                            break;
                        }
                    case 3:
                        {
                            uI.PerformanceTrackingUI();
                            break;
                        }

                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Main Menu Y/N:");
                c = Console.ReadLine();
            }
            while (c == "Y" || c =="y");

        } 
        }

    }
