using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombicide.Domain
{
    public enum WeaponType
    {
        Melee,
        Range
    }

    public class Weapon : Equipment
    {
        public WeaponType Type { get; set; }
        public int Range { get; set; }
        public int Dice { get; set; }
        public int Accuracy { get; set; }
        public int Damage { get; set; }
        public Boolean MakesNoise { get; set; }
        public Boolean CanOpenDoors { get; set; }
    }
}
