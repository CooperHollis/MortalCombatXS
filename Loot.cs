using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombatXSLoot
{
    public class Loot
    {
        public static Random rand = new Random();
        public static List<Item> lootList = new List<Item>();
        public static void Main()
        {
            Run();
        }
        public static void Run()
        {
            GenerateLoot(5);   
        }
         public static void GenerateLoot(int randItem)
        {
            int newRand = rand.Next(0, 18);
            lootList.Add(GenerateItems());
            foreach(Item item in lootList)
            {
                Console.WriteLine(item);
            }
        }
        public static Item GenerateItems()
        {
            int randValue = rand.Next(1, 51);
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
            Item item = new Item(randName, randValue);
            return item; 
        }
    }           
}
