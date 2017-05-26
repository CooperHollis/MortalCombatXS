using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombatXS
{
    class Tank : Player
    {
        Random rand = new Random();
        public Tank() : base()
        {
            BaseHealth = rand.Next(80, 176);
            BaseDamage = rand.Next(0, 101);
            DamageMod = 0;
            HealthMod = 0;
        }
    }
}
