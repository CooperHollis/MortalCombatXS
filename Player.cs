using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    public class Player
    {
        public Player()
        {


        }


        public Random Rand = new Random();
        public int BaseHealth { get; set; }
        public int currentHP { get; set; }
        public Items.Weapon eqiuppedWeapon { get; set; }
        public int Level { get; set; }
        public int BaseDamage { get; set; }
        public int HealthMod { get; set; }
        public int DamageMod { get; set; }
       



        public int Attack()
        {
            int x = eqiuppedWeapon.damageAmount;

            x += BaseDamage;
            
            return x;
        }
        public int resetHealth()
        {
            currentHP = BaseHealth;
            return currentHP;
        }

        public int SuperAttack()
        {
            int x = eqiuppedWeapon.damageAmount;

            x += BaseDamage;

            int RandNum = Rand.Next(1, x);

            return RandNum;
        }
        public int TakeDamage(int Damage)
        {
            if (Damage < 0)
            {
                Damage *= 0;
            }
            if(currentHP - Damage <= 0)
            {
                return currentHP *= 0;
            }
            
            return currentHP -= Damage;
        }


        public override string ToString()
        {
            return $"BaseHealth - {BaseHealth} CurrentHP - {currentHP} BaseDamage - {BaseDamage}\n HealthMod - {HealthMod} DamageMod - {DamageMod}\n Weapon - {eqiuppedWeapon}";

        }
    }

}
