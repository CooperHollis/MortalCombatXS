using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Driver.Run();
        }
        
    }

    public class Driver
    {
        public static void Run()
        {
            Game newGame = new Game();
            newGame.PresentMenu();
        }
    }
}
