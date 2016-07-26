using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
   public class QueryPanel
    {
        public int Id { get; set; }
        public string MatchFormat { get; set; }
        public string TeamId { get; set; }
        public string TeamName { get; set; }
        public int OppositeTeamId { get; set; }
        public string OppositeTeam { get; set; }
        public string Pitch{ get; set; } // home, away, neutral, all
        public string[] MatchResults { get; set; } // won, lost , tied , drawn


    }
}
