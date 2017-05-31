using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class ImplementationLogic
    {
            protected int level { get; set; } = 1;
            protected int xp = 0;
            protected int xpGained = 0;
            protected int mastery = 0;

        public int levelingUp()
        {
            Leveling lvl = new Leveling(level, xp, xpGained);
            //check win
            Random randy = new Random();
            xpGained = randy.Next(50, 100);

            if(/*win*/ && xp + xpGained = 200)
            {
                Console.WriteLine("You Leveled UP!!!!!");
                xp += xpGained;
                xpGained = 0;
                level += 1;
                if (level > 10)
                {
                    Player player = new Player();
                    player.DamageMod = 10;
                    player.HealthMod = 25;
                    player.BaseHealth += player.HealthMod;
                    player.BaseDamage += player.DamageMod;
                    level = 1;
                    for(int j = 0; j <= mastery; j++)
                    {
                        mastery += 1;
                    }
                }
            }

            else
            {
                xpGained += xpGained;
                xp += xpGained;
            }

            for (int i = 1; i < level; i++)
            {
                Player player = new Player();
                player.DamageMod = 10;
                player.HealthMod = 10;
                player.BaseHealth += player.HealthMod;
                player.BaseDamage += player.DamageMod;
            }
            return level;
        }
    }
}
