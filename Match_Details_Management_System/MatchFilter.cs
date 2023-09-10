using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Match_Details_Management_System
{
    internal class MatchFilter
    {
        MatchList MatchList = new MatchList();
        SwitchInterface si = new SwitchInterface(); 


        public void FilterMatchesBySport(string sportname)
        {
            var result = (from sport in MatchList.Matches where sport.Sport == sportname  select sport).ToList();
            foreach (var sport in result) { Console.WriteLine(sport); }

        }

        public void FilterMatchesByLocation(string locationname)
        {
            var result = (from location in MatchList.Matches where location.Sport == locationname select location).ToList();
            foreach (var location in result) { Console.WriteLine(location); }
        }

        public void FilterMatchesBySportDate(int year,int month,int day)
        {
            var result = (from date in MatchList.Matches where date.MatchDateTime > new DateTime(year, month, day, 12, 0, 0) select date).ToList(); 
            foreach (var match in result) { Console.WriteLine(match); }
        }

        public void FilteringChoice()
        {
            si.FilteringInterface();   
        }
    }
}
