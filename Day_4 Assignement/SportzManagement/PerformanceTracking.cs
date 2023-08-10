using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class PerformanceTracking
    {
        UserInterface ui = new UserInterface();
        Athlete a = new Athlete();
        Event e = new Event();
        List<Performance> PerformanceData = new List<Performance>()
        {
            new Performance(101,1001,"95 Not Out",2,1),
            new Performance(102,1002,"6 4 6",2,1),
            new Performance(105,1002,"12 3 4",1,2),
            new Performance(103,1003,"34 Points",1,0),
        };
        public void RecordAthletePerformance()
        {
            Performance performance = new Performance(ui.getAthleteId(), ui.getEventId(), ui.getScore(), ui.getLoss(), ui.getWin());
            PerformanceData.Add(performance);
        }

        public void GetPerformanceByAtheleteIdAndEventId()
        {
           int athleteId= ui.getAthleteId();
           int eventId= ui.getEventId();
           Performance p = PerformanceData.Find(e => e.athleteId == athleteId & e.eventId == eventId);
            
        }

        public void ViewPerformance()
        {
            foreach(Performance performance in PerformanceData)
            {
                Console.WriteLine(performance);
            }
        }
    }
    class Performance
    {
        public int athleteId { get; set; }
        public int eventId { get; set; }
        public int wins { get; set; }
        public int loss { get ; set; }  
        public string athleteScore { get; set; }

        public Performance()
        {

        }
        public Performance(int athleteId, int eventId,string athleteScore,int wins, int loss)
        {
            this.wins = wins;
            this.loss = loss;
            this.athleteScore = athleteScore;

        }
        public override string ToString()
        {
            return $"Score: {athleteScore}   Win: {wins}   Loss:{loss}";
        }
    }
}

