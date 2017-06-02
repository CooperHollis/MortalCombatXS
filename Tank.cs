using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    class Tank : Player
    {
        Random rand = new Random();
        public Tank() : base()
        {
            BaseHealth = 125;
            BaseDamage = rand.Next(25, 101);
            currentHP = BaseHealth + HealthMod;
            DamageMod = 0;
            Level = 1;
            HealthMod = 0;
            eqiuppedWeapon = Loot.GenerateItem();
        }

        public override string ToString()
        {
            return $"Name - Tank \n {base.ToString()}";

        }
    }
}
