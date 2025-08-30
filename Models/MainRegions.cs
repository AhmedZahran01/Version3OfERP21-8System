using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Version3OfERP21_8System.Models
{
    public class MainRegions
    {
        public int Id { get; set; }
        public string  MainRegionName { get; set; }
        public double start_Number { get; set; }

        public List<SubRegion> subRegions { get; set; } = new List<SubRegion>();
    }
}
