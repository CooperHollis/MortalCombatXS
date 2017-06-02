using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    public class Monster : Player
    {
        Random rand = new Random();
        public Monster(int ModMultiplier) : base()
        {
            BaseHealth = 70 + HealthMod;
            HealthMod = 10 * ModMultiplier;
            DamageMod = 10 * ModMultiplier;
            BaseDamage = 20 + DamageMod;
            currentHP = BaseHealth + HealthMod;
            DamageMod = 10 * ModMultiplier;
            eqiuppedWeapon = Loot.GenerateItem();
        }

        public override string ToString()
        {
            return $"Name - Monster \n {base.ToString()}";

        }
    }
}
