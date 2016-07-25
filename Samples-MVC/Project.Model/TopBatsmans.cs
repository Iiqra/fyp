using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
  public class TopBatsmans
    {
        public int Id { get; set; }
        public string Name { get; set; } //playerName
        public string Country { get; set; } // country name
        public string CountryInits { get; set; } //  country 
        public int Runs { get; set; } // x
        public string HighScore { get; set; } //z
        public int Matches { get; set; }
        public double avg { get; set; } //y
        public int innings{ get; set; }
        public int Fifties { get; set; } //50s
        public int Centuries { get; set; }// 100s
        public string Ground_Id { get; set; }



    }
}
