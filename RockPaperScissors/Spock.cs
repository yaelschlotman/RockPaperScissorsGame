using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Spock
    {
        public void computerThrowSpock()
        {
            bool computerWins = false;
            bool playerWins = false;
            string computerChoiceSpock;
            string playerChoice = Console.ReadLine();
            PlayerThrow playerThrow = new PlayerThrow();
            playerChoice = playerThrow.playerSign();

            switch (playerChoice) 
            {
                case "Rock":
                    Console.WriteLine("Spock vaporizes rock.  Computer wins.");
                    computerWins = true;
                    break;
                case "Paper":
                    Console.WriteLine("Paper disproves Spock.  Player wins.");
                    playerWins = true;
                    break;
                case "Scissors":
                    Console.WriteLine("Spock smashes scissors.  Computer wins");
                    computerWins = true;
                    break;
                case "Lizard":
                    Console.WriteLine("Lizard poisons Spock.  Player wins.");
                    playerWins = true;
                    break;
                default:
                    Console.WriteLine("Spock battles Spock, universe implodes.  No winner.");
                    break;
            }
        }
    }
}
