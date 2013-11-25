using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombicide.Domain
{
    public class Tile
    {
        public string TileId { get; set; }
        public IList<Zone> Zones { get; set; }
        public Tile NorthBorderTile { get; set; }
        public Tile EastBorderTile { get; set; }
        public Tile WestBorderTile { get; set; }
        public Tile SouthBorderTile { get; set; }
    }
}
