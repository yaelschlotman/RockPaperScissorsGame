using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Scissors
    {
        public void computerThrowsRock()
        {
            bool computerWins = false;
            bool playerWins = false;
            string computerChoiceScissors;
            string playerChoice = Console.ReadLine();
            PlayerThrow playerThrow = new PlayerThrow();
            playerChoice = playerThrow.playerSign();

            switch (playerChoice)
            {
                case "Rock":
                    Console.WriteLine("Rock crushes scissors.  Player wins.");
                    playerWins = true;
                    break;
                case "Paper":
                    Console.WriteLine("Scissors cut paper.  Computer wins.");
                    computerWins = true;
                    break;
                case  "Lizard":
                    Console.WriteLine("Scissors decapiitate lizard.  Computer wins");
                    computerWins = true;
                    break;
                case "Spock":
                    Console.WriteLine("Spock smashes scissors.  Player wins.");
                    playerWins = true;
                    break;
                default:
                    Console.WriteLine("Scissors commence duel.  No winner.");
                    break;
            }
        }               
    }
}
