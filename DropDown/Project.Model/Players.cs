using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap_Libraries.Models
{
    public class Players
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Age { get; set; }
        public ICollection<PlayerStatistics> Statistics { get; set; }
    }
}