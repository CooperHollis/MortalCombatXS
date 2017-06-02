using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    class Assassin : Player
    {
        Random rand = new Random();
        public Assassin()
        {
            BaseHealth = 100;
            BaseDamage = rand.Next(15, 90);
            currentHP = BaseHealth;
            DamageMod = 0;
            HealthMod = 0;
            Level = 1;
            eqiuppedWeapon = Loot.GenerateItem(); 
        }
        public override string ToString()
        {
            return $"Name - Assassin \n {base.ToString()}";

        }
    }
}