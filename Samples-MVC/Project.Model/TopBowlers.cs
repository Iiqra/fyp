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
        public string Name { get; set; }
        public string Country { get; set; }
        public double Overs { get; set; }
        public int Maidens { get; set; }
        public int Runs { get; set; }
        public int Wickets { get; set; }
        public double Avg { get; set; }
        public double StrikeRate { get; set; }
        public double Economy { get; set; }
    }
}
