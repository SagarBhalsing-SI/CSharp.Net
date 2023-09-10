namespace Match_Details_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatchManagement matchManagement = new MatchManagement();
            SwitchInterface si = new SwitchInterface();
            UserInterface ui = new UserInterface();
            Console.WriteLine("Running");
            matchManagement.DisplayMatches();
            //si.DisplayMainMenuInterface();
            //si.DisplayFeatureInterface();
            
             /*   string c;
                do
                {
                    Console.WriteLine("===============================Sports Management System===================================");
                    Console.WriteLine("==========================================================================================");
                    Console.WriteLine("1. Display Matches");
                    Console.WriteLine("2. Display Match By Id");
                    Console.WriteLine("3. Update Score By Id");
                    Console.WriteLine("4. Remove Match By Id");
                    Console.WriteLine("5. Extra Feature");
                    Console.WriteLine("6. Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            matchManagement.DisplayMatches();
                            break;
                        case 2:
                            matchManagement.GetMatchById();
                            break;
                        case 3:
                            matchManagement.UpdateMatchScoreById();
                            break;
                        case 4:
                            matchManagement.RemoveMatchById();
                            break;
                        case 5:
                            si.DisplayFeatureInterface();
                            break;
                        case 6:
                            // Exit the program
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Do you want to continue with the Matches Management System Menu Y/N:");
                    c = Console.ReadLine();
                } while (c == "Y" || c == "y");*/
            }
        }
    }



   
