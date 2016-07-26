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
        public string CountryName { get; set; } // country name
        public string CountryInits { get; set; }// countyrinits
        public double Overs { get; set; }// 
        public int Maidens { get; set; }//
        public int x { get; set; } // x
        public int y { get; set; } // y
        public double z { get; set; } // z
        public double StrikeRate { get; set; }
        public double Economy { get; set; }
        public string Ground_Id { get; set; }

    }
}
