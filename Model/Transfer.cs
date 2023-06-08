using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager_2023.Model
{
    class Transfer
    {
        public string PibTransfer { get; set; }
        public int IdTransfer { get; set; }
        public int Term { get; set; }
        public string DateBegin { get; set; }
        public string DateEnd { get; set; }
        public int Price { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public string Coach { get; set; }
        public int NumberPlayer { get; set; }
        public string ImageTransfer { get; set; }

        public Transfer(string pib, int id, int term, string datebegin, string dateend, int price, string team, string position, string coach, int num, string img)
        {
            PibTransfer = pib;
            IdTransfer = id;
            Term = term;
            DateBegin = datebegin;
            DateEnd = dateend;
            Price = price;
            Team = team;
            Position = position;
            Coach = coach;
            NumberPlayer = num;
            ImageTransfer = img;
        }
    }
}
