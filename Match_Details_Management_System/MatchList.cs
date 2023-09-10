using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Details_Management_System
{
    internal class MatchList
    {
        public List<MatchDetails> Matches = new List<MatchDetails>()
        {
        new MatchDetails(1,  "Cricket",    new DateTime(2009, 3, 8, 14, 30, 0),"Christchurch",           "New Zealand", "India",   334,392),
        new MatchDetails(2,  "Cricket",    new DateTime(2020,9,30,10,0,0),     "Wankhade",               "India",       "Srilanka",330,310),
        new MatchDetails(100,"Hockey",     new DateTime(2023,9,7,20,0,0),      "HC Rotterdam",           "Netherlands", "India",   2,  2),
        new MatchDetails(200,"FootBall",   new DateTime(2023,7,4,18,0,0),      "Sree Kanteerava Stadium","India",       "Kuwait",  5,  4),
        new MatchDetails(300,"Basketball", new DateTime(2023,2,24,15,0,0),     "Bengaluru",              "India",       "Jordan"  ,63, 98)
        };
    }
}
