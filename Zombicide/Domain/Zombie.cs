using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombicide.Domain
{
    public enum ZombieType
    {
        Walker,
        Runner,
        Fatty,
        Abomination
    }

    public class Zombie
    {
        public ZombieType Type { get; set; }
        public int Toughness;
        public int Actions;
        public int ActionsUsed;
    }
}
