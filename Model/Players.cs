using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Football_Manager_2023.Model
{
    public class Players
    {
        public int Id { get; set; }
        public string Pib { get; set; }
        public string IdTeam { get; set; }
        public int PlayerNumber { get; set; }
        public string DateBorn { get; set; }
        public string Position { get; set; }
        public string Coach { get; set; }
        public string ImagePlayer { get; set; }
        public string ImageTeam { get; set; }

        public Players(int id, string pib, string team, int num, string date, string pos, string coach, string img_player, string img_team)
        {
            Id = id;
            Pib = pib;
            IdTeam = team;
            PlayerNumber = num;
            DateBorn = date;
            Position = pos;
            Coach = coach;
            ImagePlayer = img_player;
            ImageTeam = img_team;
        }
    }
}
