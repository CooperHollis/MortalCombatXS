using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    public interface IConsumable
    {
        void Use(Player target);
        void GetDescription();
    }
    public class Item
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
