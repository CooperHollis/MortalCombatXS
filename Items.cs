using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombatXSLoot
{
    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string name, int value)
        {
            Value = value;
            Name = name;
        }
        public override string ToString()
        {
            return $"{GetType().Name} name: {Name} | value = {Value} ";
        }
    }
}
