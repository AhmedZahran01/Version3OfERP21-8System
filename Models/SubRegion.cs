using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version3OfERP21_8System.Models
{
    public class SubRegion
    {
        public int Id { get; set; }
        public string subRegionName { get; set; } 

        public string MainRegionName { get; set; }

        [ForeignKey("MainRegions")]
        public int mainRegionsId { get; set; }
        public MainRegions mainRegions { get; set; }

    }
}
