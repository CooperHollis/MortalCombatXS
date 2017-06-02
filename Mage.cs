using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    public class Mage : Player
    {
        Random rand = new Random();
        public Mage() : base()
        {
            BaseHealth = 150;
            BaseDamage = rand.Next(0, 60);
            currentHP = BaseHealth + HealthMod;
            DamageMod = 0;
            Level = 1;
            HealthMod = 0;
            eqiuppedWeapon = Loot.GenerateItem();
        }

        public override string ToString()
        {
            return $"Name - Mage \n {base.ToString()}";

        }
    }
}
