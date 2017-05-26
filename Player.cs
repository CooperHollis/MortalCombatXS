using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombatXS
{
    public class Player
    {
        public int BaseHealth { get; set; }
        public int BaseDamage { get;  set; }
        public int HealthMod { get; set; }
        public int DamageMod { get; set; }

        public Player()
        {
            BaseHealth = 10;
            BaseDamage = 10;
            HealthMod = 0;
            DamageMod = 0;
        }
    }
}
