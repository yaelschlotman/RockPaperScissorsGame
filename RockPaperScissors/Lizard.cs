using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Lizard
    { 
        public void computerThrowsLizard() {
            bool computerWins = false;
            bool playerWins = false;
            bool computerChoiceLizard = true;
            string playerChoice = Console.ReadLine();
            PlayerThrow playerThrow = new PlayerThrow();
            playerChoice = playerThrow.playerSign();
            

            switch (playerChoice)
            {
                case "Rock":
                    Console.WriteLine("Rock crushes lizard.  Player wins.");
                    playerWins = true;
                    break;
                case "Paper":
                    Console.WriteLine("Lizard eats paper.  Computer wins.") ;
                    computerWins = true;
                    break;
                case "Scissors":
                    Console.WriteLine("Scissors decapiitate lizard.  Player wins");
                    playerWins = true;
                    break;
                case "Spock":
                    Console.WriteLine("Lizard poisons Spock.  Computer wins.");
                    computerWins = true;
                    break;
                default:
                    Console.WriteLine("Scissors commence duel.  No winner.");
                    break;
            }
        }
    }
}
