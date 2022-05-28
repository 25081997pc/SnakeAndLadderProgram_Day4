using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class GameStart
    {
        const int NO_PLAY = 1;
        const int LADDER = 2;
        const int SNAKE = 3;
        public static void GameIsStart()
        {
            int players = 1;
            int Player1Position = 0;
            int DiceCount = 0;
            
            Console.WriteLine("Player1 Position: " + Player1Position);

            Random random = new Random();
            while(Player1Position != 100 || Player1Position < 100)
            {
                int DieRoll = random.Next(1, 7);
                DiceCount++;
                Console.WriteLine("Rolling the Die: " + DieRoll);

                int check = random.Next(1, 4);
                switch (check)
                {
                    case NO_PLAY:
                        Player1Position = Player1Position + 0;
                        break;
                    case LADDER:
                        Player1Position = Player1Position + DieRoll;
                        if (Player1Position > 100)
                            Player1Position = Player1Position - DieRoll;
                        break;
                    case SNAKE:
                        Player1Position = Player1Position - DieRoll;
                        break;
                }
                if (Player1Position < 0)
                    Player1Position = 0;
                Console.WriteLine("Position of Player1 is: " + Player1Position);

            }
            Console.WriteLine("Player1 reached to Winning Position at 100");
            Console.WriteLine("{0} times Roll the Die: ", DiceCount);
        }       

    }
}   
            

        
         
    

