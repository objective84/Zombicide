using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombicide.Domain
{
   public class Survivor
   {
       public String Name { get; set; }
       public int Exp { get; set; }
       public int Actions { get; set; }
       public int ActionsUsed { get; set; }
       public Ability BlueAbility { get; set; }
       public Ability YellowAbility { get; set; }
       public Ability OrangeAbility { get; set; }
       public Ability RedAbility { get; set; }
       public IList<Ability> OrangeAbilities { get; set; } 
       public IList<Ability> RedAbilities { get; set; } 
       public Equipment MainHand { get; set; }
       public Equipment OffHand { get; set; }
       public Equipment ReserveA { get; set; }
       public Equipment ReserveB { get; set; }
       public Equipment ReserveC { get; set; }
   }
}
