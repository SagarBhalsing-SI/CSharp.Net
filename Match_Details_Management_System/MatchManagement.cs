namespace Match_Details_Management_System
{
    internal class MatchManagement
    {
        UserInterface ui = new UserInterface();
        MatchList MatchList = new MatchList();  

        public void DisplayMatches()
        {
            Console.WriteLine("---------------------------------------Match List-------------------------------------------");
            Console.WriteLine("==============================================================================================");
            MatchList.Matches.ForEach(p => Console.WriteLine(p + "\n" + "========================================="));
        }

        public void GetMatchById()
        {
            int id = ui.getId();
            MatchDetails MatchById = MatchList.Matches.Find(m => m.MatchId.Equals(id));
            Console.WriteLine("\n" + MatchById);
        }

        public void UpdateMatchScoreById()
        {
            int id = ui.getId();
            MatchDetails MatchById = MatchList.Matches.Find(m => m.MatchId.Equals(id));
            MatchById.HomeTeamScore = ui.getNewHomeTeamScore();
            MatchById.AwayTeamScore = ui.getNewAwayTeamScore();
            ui.UpdateSuccessfully();
        }


        public void RemoveMatchById()
        {
            int id = ui.getId();
            MatchDetails MatchById = MatchList.Matches.Find(m => m.MatchId.Equals(id));
            MatchList.Matches.Remove(MatchById);
        }


    }
}
