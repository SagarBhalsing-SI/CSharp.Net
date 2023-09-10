using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Details_Management_System
{
    internal class SwitchInterface
    {
        MatchSort matchSort = new MatchSort();
        UserInterface ui = new UserInterface();
        MatchFilter matchFilter = new MatchFilter();
        MatchSearch matchSearch = new MatchSearch();    
        MatchManagement matchManagement = new MatchManagement();    
        public void SortingInterface()
        {
            string c;
            do
            {
                int choice = ui.getSort();
                switch (choice)
                {
                    case 1:
                        {
                            matchSort.SortMatchesBySport(ui.getOrder());
                            break;
                        }
                    case 2:
                        {
                            matchSort.SortMatchesByLocation(ui.getOrder());
                            break;
                        }
                    case 3:
                        {
                            matchSort.SortMatchesByDate(ui.getOrder());
                            break;
                        }

                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Sort Menu Y/N:");
                c = Console.ReadLine();
            } while (c == "Y");
        }

        public void FilteringInterface()
        {
            string c;
            do
            {
                int choice = ui.getFilter();
                switch (choice)
                {
                    case 1:
                        {
                            matchFilter.FilterMatchesBySport(ui.getSportFilter());
                            break;
                        }
                    case 2:
                        {
                            matchFilter.FilterMatchesByLocation(ui.getLocationFilter());
                            break;
                        }
                    case 3:
                        {
                            matchFilter.FilterMatchesBySportDate(ui.getYear(), ui.getMonth(), ui.getDay());
                            break;
                        }

                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Filter Menu Y/N:");
                c = Console.ReadLine();
            } while (c == "Y");
        }

        public void DisplayFeatureInterface()
        {
            string c;
            do
            {
                int choice = ui.getMatchDisplayFeature();

                switch (choice)
                {
                    case 1:
                        {
                            matchSort.SortingChoice();
                            break;
                        }
                    case 2:
                        {
                            matchFilter.FilteringChoice();
                            break;
                        }
                    case 3:
                        {
                            matchSearch.SearchMatch();
                            break;
                        }

                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Extra Feature Menu Y/N:");
                c = Console.ReadLine();
            } while (c == "Y");
        }

        public void DisplayMainMenuInterface()
        {
            string c;
            do
            {
                ui.getSportsManagementSystem();

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            matchManagement.DisplayMatches();
                            break;
                        }
                    case 2:
                        {
                            matchManagement.GetMatchById();
                            break;
                        }

                    case 3:
                        {
                            matchManagement.UpdateMatchScoreById();
                            break;
                        }
                    case 4:
                        {
                            matchManagement.RemoveMatchById();
                            break;
                        }
                    case 5:
                        {
                            DisplayFeatureInterface();
                            break;
                        }
                    case 6:
                        {

                            break;
                        }
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Matches Management System Menu Y/N:");
                c = Console.ReadLine();
            }
            while (c == "Y");
        }
    }
}
