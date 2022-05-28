using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class GamePlay
    {
        static int Player1Position = 0;
        static int Player2Position = 0;
        const int NO_PLAY = 1;
        const int LADDER = 2;
        const int SNAKE = 3;
        static Random random = new Random();
        static int flag = 0;
        public static void GameIsPlay()
        {
            int players = 2;
            int Player1Position = 0;
            int Player2Position = 0;

            Console.WriteLine("Player1 Position: " + Player1Position);
            Console.WriteLine("Player1 Position: " + Player1Position);
            Random random = new Random();
            int Die1 = random.Next(1, 7);
            int Die2 = random.Next(1, 7);
            while (Player1Position < 100 && Player2Position < 100)
            {
                do
                {
                    Console.WriteLine("Player1 Position : ", Player1Position);
                    Player1Position = startgame(Player1Position);
                    Die1++;
                    Console.WriteLine("Player1 Position : ", Player1Position);
                }
                while (flag == 1);
                do
                {
                    Console.WriteLine("Player2 Position: " + Player2Position);
                    Player2Position = startgame(Player2Position);
                    Die2++;
                    Console.WriteLine("Player2 Position: " + Player2Position);
                }
                while (flag == 1);

            }
            if (Player1Position == 100)
            {
                Console.WriteLine("Player1 is win using num of dice: " + Die1);
            } else
            {
                Console.WriteLine("Player2 is win using num of dice: " + Die2);
            }
        }
        public static int startgame(int Player)
        {
            flag = 0;
            int DieRoll = random.Next(1, 7);
            
            Console.WriteLine("Die is Rolling :" + DieRoll);
            int check = random.Next(1, 4);
            switch (check)
            {
                case NO_PLAY:
                    Player = Player + 0;
                    break;
                case LADDER:
                    Player = Player + DieRoll;
                    if (Player > 100)
                        Player = Player - DieRoll;
                    break;
                case SNAKE:
                    Player = Player - DieRoll;
                    if (Player < 0)
                        Player = 0;
                    break;
            }
            return Player;
            
        } 
            
            
    }
}
