using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
   public class BowlingRecords
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public int Matches { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public int Tied { get; set; }
        public int NR { get; set; }
        public int Runs { get; set; }
        public int Wickets { get; set; }
        public int Balls { get; set; }
        public decimal Average { get; set; }
        public decimal RPO { get; set; }
    }
}
