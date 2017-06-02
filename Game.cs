using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;
using System.IO;



namespace MCXS
{
    public class Game
    {
        public static Dictionary<String, String> player1 = new Dictionary<String, String>();
        public void PresentMenu()
        {
            String[] MainMenu = {"Start New Game"};
            int MenuSelection = CIO.PromptForMenuSelection(MainMenu, true);

            if(MenuSelection == 1)
            {
                BeginGame();
            }
           
            else if(MenuSelection == 0)
            {
                 
            }
        }
        public void BeginGame()
        {
            Player player = InGameLogic.CharacterSelection();
            InGameLogic.BattleLogic(player);
        }
       
    }
}
