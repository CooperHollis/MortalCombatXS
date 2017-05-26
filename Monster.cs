using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombatXS
{
    public class Monster : Player
    {
        Random rand = new Random();
        public Monster(int ModMultiplier) : base()
        {
            BaseHealth = rand.Next(75, 151);
            BaseDamage = rand.Next(15, 80);
            HealthMod = 10 * ModMultiplier;
            DamageMod = 10 * ModMultiplier;
        }

    }
}
