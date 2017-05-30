using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Leveling
    {
        protected int level { get; set; }
        protected int xp { get; set; }
        protected int xpGained { get; set; }

        public Leveling(int level, int xp, int xpGained)
        {
            this.level = level;
            this.xp = xp;
            this.xpGained = xpGained;
        }


        public int baseLevel()
        {
            if (level < 0)
            {
                level = 1;
            }
            return level;
        }

        public int gainedExp()
        {
            Random randy = new Random();
            xpGained = randy.Next(100, 200);
            if (xpGained > 100 || xpGained < 0)
            {
                xpGained = 100;
            }
            return xpGained;
        }

        public int overallXP()
        {
            if (xp <= 0)
            {
                if (xpGained == 0)
                {
                    xp = 0;
                }

                else if (xpGained > 0)
                {
                    xp += xpGained;
                }
            }
            xp += xpGained;
            return xp;
        }
    }
}
