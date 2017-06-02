using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace MCXS
{
    public class InGameLogic
    {
        public static int ModMultiplier = 0;
        public static int Level = 1;
        
        public static Player CharacterSelection()
        {
            Game game = new Game();
            Console.WriteLine("Choose Character");
            Console.WriteLine("");
            String[] CharacterSelect = { "Assassin", "Mage", "Tank" };

            int MenuSelection = CIO.PromptForMenuSelection(CharacterSelect, true);

            if(MenuSelection == 1)
            {
                Player player = new Assassin();
                return player;
            }
            else if(MenuSelection == 2)
            {
                Player player = new Mage();
                return player;
            }
            else if(MenuSelection == 3)
            {
                Player player = new Tank();
                return player;
            }
            else
            {
                game.BeginGame();
                return null;
            }
            
        }
        public static void BattleLogic(Player player)
        {
            bool Alive = true;
            Random Rand = new Random();
            int PSAttack = 0;
            int playerChoice = 0;
            Monster Mon = new Monster(ModMultiplier);
            

            Console.WriteLine();
            Console.WriteLine("Level " + player.Level);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(player + "\n \n VS. \n \n" + Mon);
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Start Battle");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            do
            {
                //Player Logic

                Console.WriteLine("Player's Turn");
                Console.WriteLine();

                if (PSAttack != 1)
                {
                    playerChoice = CIO.PromptForInt("Enter 1. Attack, 2. Potion, or 3. SuperAttack", 1, 3);
                }
                else
                {

                    playerChoice = CIO.PromptForInt("Enter 1. Attack or 2. Potion", 1, 2);
                }


                
                if (playerChoice == 1)
                {
                    int Attack = player.Attack();
                    Mon.TakeDamage(Attack);
                    Console.WriteLine("Monster Deals " + Attack + " Amount of Damage");
                    Console.WriteLine();
                    Console.WriteLine(Mon);
                }
                else if (playerChoice == 2)
                {
                    IConsumable Pot = new Items.Health
                    {
                        HealAmount = Rand.Next(10, 40)
                    };
                    Pot.GetDescription();
                    Console.WriteLine();
                    Pot.Use(player);
                    Console.WriteLine(player);
                    Console.WriteLine();
                }
                else if (PSAttack != 1 && playerChoice == 3)
                {
                    int SuperAttack = player.SuperAttack();
                    Mon.TakeDamage(SuperAttack);
                    Console.WriteLine("Player Deals " + SuperAttack + " Amount of Damage");
                    Console.WriteLine();
                    Console.WriteLine(Mon);
                    PSAttack++;
                }

                if (Mon.currentHP <= 0)
                {
                    Console.WriteLine("You Win!!!");
                    player.resetHealth();
                    ModMultiplier++;
                    Level++;
                    NextLevel(player);


                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Monster's Turn");
                Console.WriteLine();
                Console.WriteLine("Enter to View Turn");
                String Enter = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();



                //Monster Logic
                if (Mon.currentHP > Mon.BaseHealth / 2)
                {
                    int Attack = Mon.Attack();
                    player.TakeDamage(Attack);
                    Console.WriteLine("Monster Deals " + Attack + " Amount of Damage");
                    Console.WriteLine();
                    Console.WriteLine(player);
                }
                else if (Mon.currentHP < Mon.BaseHealth / 2)
                {
                    IConsumable Pot = new Items.Health
                    {
                        HealAmount = Rand.Next(10, 30)
                    };
                    Pot.GetDescription();
                    Console.WriteLine();
                    Pot.Use(Mon);
                    Console.WriteLine(Mon);
                }


                if (player.currentHP <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Monster Defeats Player");
                    Console.WriteLine("You Are A Loser");
                    Console.WriteLine();
                    Console.WriteLine();
                    Driver.Run();
                }
            } while (Alive);
           

        }
        public static void NextLevel(Player player)
        {
            Console.WriteLine();
            Console.WriteLine("Enter to Begin Next Level");
            String Enter = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            ImplementationLogic n = new ImplementationLogic();
            int x = n.levelingUp(player);
            if(x < 20)
            {
                BattleLogic(player);
            }
        }
    }
}
