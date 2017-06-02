using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS.Items
{
    public class Weapon : Item
    {
        public int damageAmount { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}\n Damage Amount: {damageAmount}";
        }
                    
  
    }
}
