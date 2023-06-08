using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager_2023.Model
{
    class Plans
    {
        public int IdPlayer { get; set; }
        public string Pib { get; set; }
        public string Position { get; set; }
        public int NumberPlayer { get; set; }
        public string NamePlan { get; set; }

        public Plans(int id, string pib, string position, int num, string plan)
        {
            IdPlayer = id;
            Pib = pib;
            Position = position;
            NumberPlayer = num;
            NamePlan = plan;
        }

    }
}
