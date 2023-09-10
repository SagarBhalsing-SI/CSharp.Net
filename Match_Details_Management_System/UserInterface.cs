namespace Match_Details_Management_System
{
    internal class UserInterface
    {
        public int getId()
        {

            Console.WriteLine("Enter Match Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public int getNewHomeTeamScore()
        {
            Console.WriteLine("Enter New Score:");
            int score = Convert.ToInt32(Console.ReadLine());
            return score;
        }

        public int getNewAwayTeamScore()
        {
            Console.WriteLine("Enter New Score:");
            int score = Convert.ToInt32(Console.ReadLine());
            return score;
        }

        public void UpdateSuccessfully()
        {
            Console.WriteLine("Updated Successfully.");
        }

        public int getSort()
        {
            Console.WriteLine("Enter your type of Match sorting: ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Sort By Sport: " +
                              "2. Sort By Location:  " +
                              "3. Sort By Date");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }

        public string getOrder()
        {
            Console.WriteLine("          Order By" +
                              "==============================" +
                              "1. Order By Ascending  (Asc)" +
                              "2. Order By Descending (Dsc)");
            string order = Console.ReadLine();
            return order;
        }
        public int getMatchDisplayFeature()
        {
            Console.WriteLine("Enter your choice: ");
            Console.Write("==============================");
            Console.WriteLine("1. Sort Match" +
                              "2. Filter Match" +
                              "3. Search Match");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public int getFilter()
        {
            Console.WriteLine("Enter your type of Match sorting: ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Filter By Sport: " +
                              "2. Filter By Location:  " +
                              "3. Filter By Date");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public string getSportFilter()
        {
            Console.WriteLine("Enter the Sport you want to Filter:");
            string sport = Console.ReadLine();
            return sport;
        }

        public string getLocationFilter()
        {
            Console.WriteLine("Enter the Location you want to Filter:");
            string location = Console.ReadLine();
            return location;
        }

        public int getYear()
        {
            Console.WriteLine("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine()); 
            return year;
        }

        public int getMonth()
        {
            Console.WriteLine("Enter Month: ");
            int Month = Convert.ToInt32(Console.ReadLine());
            return Month;
        }

        public int getDay()
        {
            Console.WriteLine("Enter Day: ");
            int Day = Convert.ToInt32(Console.ReadLine());
            return Day;
        }

        public void getSportsManagementSystem()
        {
            Console.WriteLine("===============================Sports Management System===================================");
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("1. Display Matches" +
                              "2. Display Matche By Id" +
                              "3. Update Score By Id" +
                              "4. Remove Match bY Id" +
                              "5. Extra Feature" +
                              "6. Exit");
        }
    }
}
