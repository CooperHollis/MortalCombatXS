using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    public class Loot
    {
        public static Random rand = new Random();
        public static List<Item> lootList = new List<Item>();

        public static Items.Weapon GenerateItem()
        {

            string[] randNames = new string[]
            {
                "Machete",
                "Bazooka",
                "Royal Helmet",
                "Fire Sword",
                "Gold Coin",
                "Red Rum",
                "Flat Bread",
                "Bacon",
                "Golden Trophy",
                "Bag of Herbs",
                "Short Sword",
                "Nunchuku",
                "Bow & Arrow",
                "Holy Grail",
                "Selfie Stick",
                "Iphone 6 Plus",
                "Samsung Galaxy S8",
                "Nokia Phone",
            };

            string randName = randNames[rand.Next(0, randNames.Length - 1)];
           
            int DAmount = rand.Next(1, 51);
            Items.Weapon Weapon = new Items.Weapon()
            {
                Name = randName,
                damageAmount = DAmount
                
            };
            return Weapon;
        }
    }
}
