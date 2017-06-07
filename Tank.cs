using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CharacterClasses
{
    class Tank
    {
        protected string name;
        protected int baseHealth { get; set; }
        protected int baseDamage { get; set; }
        protected int healthMod { get; set; }
        protected int damageMod { get; set; }
        protected int level { get; set; }
        public Tank(string name, int level, int baseHealth, int baseDamage)
        {
            if (baseHealth > 175 || baseHealth < 80)
            {
                baseHealth = 130;
            }
            if (baseDamage > 100 || baseDamage < 50)
            {
                baseDamage = 70;
            }

            this.name = name;
            this.level = level;
            this.baseHealth = baseHealth;
            this.baseDamage = baseDamage;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Class: " + name);
            str.Append("Health: " + baseHealth);
            str.Append("Damage: " + baseDamage);

            return str.ToString();
        }
    }
}

