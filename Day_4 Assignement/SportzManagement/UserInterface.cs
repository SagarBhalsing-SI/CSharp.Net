using System.Reflection.Metadata.Ecma335;

namespace SportzManagement
{
    internal class UserInterface
    {
        public int getId()
        {

            Console.WriteLine("Enter Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        public int getAthleteId()
        {

            Console.WriteLine("Enter Athelete Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public int getEventId()
        {
            Console.WriteLine("Enter Event Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        public string getFirstName()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            return firstName;
        }

     
        public string getLastName()
        {
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public int getAge()
        {
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public string getSport()
        {
            Console.WriteLine("Enter Sport:");
            string sport = Console.ReadLine();
            return sport;

        }

        public string getDate()
        {
            Console.WriteLine("Enter Date:");
            string date = Console.ReadLine();
            return date;

        }

        public string getType()
        {
            Console.WriteLine("Enter Type:");
            string type = Console.ReadLine();
            return type;
        }
        string firstName;
        string lastName;
        int age;
        string sport;
        public string getInputFirstName()
        {
            Console.WriteLine("Do you want to Update FirstName Y/N");
            string choice = Console.ReadLine();
            if (choice == "Y")
            {
                firstName = getFirstName();
            }
            return firstName;
        }
        public string getInputLastName()
        {
            Console.WriteLine("Do you want to Update LastName  Y/N");
            string choice1 = Console.ReadLine();
            if (choice1 == "Y")
            {
                lastName = getLastName();
            }
            return lastName;
        }
        public int getInputAge()
        {
            Console.WriteLine("Do you want to Update Age  Y/N");
            string choice2 = Console.ReadLine();
            if (choice2 == "Y")
            {
                age = getInputAge();
            }
            return age;
        }

        public string getInputSport()
        {
            Console.WriteLine("Do you want to Update Sport  Y/N");
            string choice3 = Console.ReadLine();
            if (choice3 == "Y")
            {
                sport = getSport();
            }
            return sport;
        }

        int win;
        int loss;
        public int getWin()
        {
            Console.WriteLine("Enter Athlete Wins: ");
            int win = Convert.ToInt32(Console.ReadLine());  
            return win; 
        }

        public int getLoss()
        {
            Console.WriteLine("Enter Athlete Loss: ");
            int loss = Convert.ToInt32(Console.ReadLine());
            return loss;
        }
        string score;
        public string getScore() 
        {
            Console.WriteLine("Enter Athlete Score:");
            string score = Console.ReadLine();
            return score;
        }


        public void UpdateSuccessfully()
        {
            Console.WriteLine("Updated Successfully.");
        }

        public string getEventName()
        {
            Console.WriteLine("Enter Event Name:");
            string eventName = Console.ReadLine();
            return eventName;
        }

        public string getEventType()
        {
            Console.WriteLine("Enter Event Type:");
            string eventType = Console.ReadLine();
            return eventType;
        }

        public string getEventDate()
        {
            Console.WriteLine("Enter Event Date:");
            string eventDate = Console.ReadLine();
            return eventDate;
        }

        string eventName;
        public string getInputEventName()
        {
            Console.WriteLine("Do you want to Update Event Name Y/N");
            string choice = Console.ReadLine();
            if (choice == "Y")
            {
                eventName = getEventName();
            }
            return eventName;
        }

        string eventType;
        public string getInputEventType()
        {
            Console.WriteLine("Do you want to Update Event Type: Y/N");
            string choice = Console.ReadLine();
            if (choice == "Y")
            {
                eventType = getEventType();
            }
            return eventType;
        }

        string eventDate;
        public string getInputEventDate()
        {
            Console.WriteLine("Do you want to Update Event Date Y/N");
            string choice = Console.ReadLine();
            if (choice == "Y")
            {
                eventDate = getEventDate();
            }
            return eventDate;
        }

    }
}
