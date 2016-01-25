using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rock
    {
         public void computerThrowsRock()
        {
            bool computerWins = false;
            bool playerWins = false;
            bool computerChoiceRock = true;
            string playerChoice = Console.ReadLine();
            PlayerThrow playerThrow = new PlayerThrow();
            playerChoice = playerThrow.playerSign();

            switch (playerChoice)
            {
                case "Paper":
                    Console.WriteLine("Paper covers rock.  Player wins.");
                    playerWins = true;
                    break;
                case "Scissors":
                    Console.WriteLine("Rock crushes scissors.  Computer wins.");
                    computerWins = true;
                    break;
                case "Lizard":
                    Console.WriteLine("Rock crushes lizard.  Computer wins");
                    computerWins = true;
                    break;
                case "Spock":
                    Console.WriteLine("Spock vaporizes rock.  Player wins.");
                    playerWins = true;
                    break;
                default:
                    Console.WriteLine("Rocks smash into each other.  No winner.");
                    break;
            }

        }
    }


}
