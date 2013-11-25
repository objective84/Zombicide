using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombicide.Domain
{
    public class Zone
    {
        public String ZoneId { get; set; }
        public Border NorthBorder { get; set; }
        public Border EastBorder { get; set; }
        public Border WestBorder { get; set; }
        public Border SouthBorder { get; set; }
    }
}
