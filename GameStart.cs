using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class GameStart
    {
       
        public static void GameIsStart()
        {
            int players = 1;
            int Player1Position = 0;

            Console.WriteLine("Player1 Position: " + Player1Position);

            Random random = new Random();
            int Die = random.Next(1, 7);

            Console.WriteLine("Rolling the Die: " + Die);

        }
         
    }
}
