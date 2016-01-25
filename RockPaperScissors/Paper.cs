using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Paper
    {
        public void computerThrowsRock()
        {
            bool computerWins = false;
            bool playerWins = false;
            bool computerChoicePaper = true;
            string playerChoice = Console.ReadLine();
            PlayerThrow playerThrow = new PlayerThrow();
            playerChoice = playerThrow.playerSign();

            switch (playerChoice)
            {
                case "Rock":
                    Console.WriteLine("Paper covers rock.  Computer wins.");
                    computerWins = true;
                    break;
                case "Scissors":
                    Console.WriteLine("Scissors cut paper.  Player wins.");
                    playerWins = true;
                    break;
                case "Lizard":
                    Console.WriteLine("Lizard eats paper.  Player wins");
                    playerWins = true;
                    break;
                case "Spock":
                    Console.WriteLine("Paper disproves Spock.  Computer wins.");
                    computerWins = true;
                    break;
                default:
                    Console.WriteLine("Papers float to ground.  No winner.");
                    break;
            }
        }        
    }
}
