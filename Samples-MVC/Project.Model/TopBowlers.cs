using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
  public  class TopBowlers
    {
        public int Id { get; set; }
        public string Name { get; set; } // player name
        public string Country { get; set; }
        public string CountryInits { get; set; }
        public double Overs { get; set; }
        public int Maidens { get; set; }
        public int Runs { get; set; } // x
        public int Wickets { get; set; } // y
        public double Avg { get; set; } // z
        public double StrikeRate { get; set; }
        public double Economy { get; set; }
        public string Ground_Id { get; set; }

    }
}
