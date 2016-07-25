using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap_Libraries.Models
{
    public class PlayerStatistics
    {
        public int Id { get; set; }
        public int Runs { get; set; }
        public double StrikeRate { get; set; }
        public int HighScore { get; set; }
        public double Average { get; set; }
        public int PlayerId { get; set; }
    }
}