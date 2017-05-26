using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombatXS
{
    public class Mage : Player
    {
        Random rand = new Random();       
        public Mage() : base()
        {
            BaseHealth = rand.Next(70, 151);
            BaseDamage = rand.Next(0, 81);
            DamageMod = 0;
            HealthMod = 0;
        }
    }
}
