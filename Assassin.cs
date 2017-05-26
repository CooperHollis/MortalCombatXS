using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombatXS
{
    class Assassin : Player
    {
        Random rand = new Random();
        public Assassin()
        {
            BaseHealth = rand.Next(60, 141);
            BaseDamage = rand.Next(15, 71);
            DamageMod = 0;
            HealthMod = 0;
        }
    }
}
