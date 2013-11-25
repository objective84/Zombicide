using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombicide.Domain
{
    public class Border
    {
        public Zone ConnectingZoneA { get; set; }
        public Zone ConnectingZoneB { get; set; }
        public Door Door { get; set; }
        public Boolean IsPassable;
    }
}
