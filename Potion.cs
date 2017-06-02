using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS.Items
{
    public class Health : Item, IConsumable
    {
        public int HealAmount { get; set; }

        public void GetDescription()
        {
            Console.WriteLine($"Player Receives {HealAmount} Health");
        }

        public void Use(Player target)
        {
            if (target.currentHP + HealAmount > target.BaseHealth)
            { 
                target.currentHP = target.BaseHealth;
            }
            else
            {
                target.currentHP += HealAmount;
            }
        }


        public override string ToString()
        {
            return $"{base.ToString()}\n HPs - {HealAmount}";
        }
    }
}
