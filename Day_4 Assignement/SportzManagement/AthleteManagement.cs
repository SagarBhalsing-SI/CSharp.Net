namespace SportzManagement
{
    internal class AthleteManagement
    {
        List<Athlete> AthleteList = new List<Athlete>()
        {
            new Athlete(101 ,"Sagar","Bhalsing",21,"Cricket","01-06-2023"),
            new Athlete(102 , "Anas","Shaikh",21,"Table Tennis","01-06-2023"),
            new Athlete(103 , "Anchal","Shing",20,"BasketBall","01-06-2023"),
            new Athlete(104 , "Jay","Patil",21,"Chess","01-06-2023"),
            new Athlete(105 , "Sapna","Bhalsing",20,"Table Tennis","01-06-2023"),
        };
        UserInterface ui = new UserInterface();
        public void ViewAthlete()
        {
            Console.WriteLine("---------------------------------------Athlete List-------------------------------------------");
            Console.WriteLine("==============================================================================================");
            foreach (Athlete a in AthleteList)
            {
                Console.WriteLine($"FirstName:{a.firstName}  LastName:{a.lastName}  Age:{a.age}  Sport:{a.sport}  Date:{a.dateTime}");
            }
        }
        public void RegisterAthlete()
        {
            Athlete a1 = new Athlete(ui.getId(), ui.getFirstName(),ui.getLastName(),ui.getAge(), ui.getSport(), ui.getDate());
            AthleteList.Add(a1);
        }
        public void GetAthleteById()
        {
          
                int id = ui.getId();
                Athlete a = AthleteList.Find(e => e.athleteId.Equals(id));
                Console.WriteLine(a); 
            
        }

        public void UpdateAthlete()
        {
            int id = ui.getId();
            Athlete a = AthleteList.Find(e => e.athleteId.Equals(id));
            a.firstName = ui.getInputFirstName();
            a.lastName = ui.getInputLastName();
            a.age = ui.getInputAge();
            a.sport = ui.getInputSport(); 
            ui.UpdateSuccessfully();
        }


        public void RemoveAthlete()
        {
            int id = ui.getId();
            Athlete a = AthleteList.Find(e => e.athleteId.Equals(id));
            AthleteList.Remove(a);
        }

        public void GetAthleteBySport()
        {
            Athlete a1 = new Athlete();
            string sport = ui.getSport();
            var result = from athlete in AthleteList where a1.sport == sport select athlete;
            foreach (var athlete in result)
            {
               Console.WriteLine(athlete);
            }
            Console.WriteLine();
        }
    }
}


