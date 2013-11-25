using System;
using System.Collections.Generic;

namespace Zombicide.Domain
{
    public class Player
    {
        public String Name{ get; set; }
        public IList<Survivor> Survivors { get; set; }
        
        
    }
}
