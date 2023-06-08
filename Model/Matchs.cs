using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager_2023.Model
{
    class Matchs
    {
        public int IdMatch { get; set; }
        public string TeamHome { get; set; }
        public string TeamGuest { get; set; }
        public string Date { get; set; }
        public string NamePlan { get; set; }
        public int Ball { get; set; }
        public int Pass { get; set; }
        public string Result { get; set; }
        public string Sezon { get; set; }
        public string ImageMatch { get; set; }

        public Matchs(int id, string home, string guest, string date, string plan, int ball, int pass, string result, string sezon, string img)
        {
            IdMatch = id;
            TeamHome = home;
            TeamGuest = guest;
            Date = date;
            NamePlan = plan;
            Ball = ball;
            Pass = pass;
            Result = result;
            Sezon = sezon;
            ImageMatch = img;
        }
    }
}
