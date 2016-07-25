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
        public string Name { get; set; }
        public string Country { get; set; }
        public int Runs { get; set; }
        public string HighScore { get; set; }
        public int Matches { get; set; }
        public double avg { get; set; }
        public int innings{ get; set; }
        public int Fifties { get; set; } //50s
        public int Centuries { get; set; }// 100s


    }
}
