using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MCXS
{
    public class ImplementationLogic
    {
        protected int level { get; set; } = 1;
        protected int xp = 0;
        protected int xpGained = 0;
        protected int mastery = 0;

        public int levelingUp(Player player)
        {
            Leveling lvl = new Leveling(level, xp, xpGained);
            //check win
            Random randy = new Random();
            xpGained = randy.Next(50, 100);

                Console.WriteLine("You Leveled UP!!!!!");
                xp += xpGained;
                xpGained = 0;
                
               
                player.Level += level;
                if (player.Level > 10)
                {
                   
                    player.DamageMod = 10;
                    player.HealthMod = 25;
                    player.BaseHealth += player.HealthMod;
                    player.BaseDamage += player.DamageMod;
                    level = 1;
                    for (int j = 0; j <= mastery; j++)
                    {
                        mastery += 1;
                    }
                }
            

            else
            {
                xpGained += xpGained;
                xp += xpGained;
            }

            return level;
        }
    }
}

