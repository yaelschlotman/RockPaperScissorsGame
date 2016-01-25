using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class PlayerThrow
    {
        string playerChoice;

        public string  playerSign()
        {
            
            Console.Write("Choose Rock, Paper, Scissors, Lizard, or Spock");
            string userInput = Console.ReadLine();
           // string responseCheck = userInput.ToLower();

            switch (userInput)
            {
                case "rock":
                    Console.WriteLine("Player: Rock");
                    playerChoice = "Rock";
                    break;
                case "paper":
                    Console.WriteLine("Player: Paper");
                    playerChoice = "Paper";
                    break;
                case "scissors":
                    Console.WriteLine("Player: Scissors");
                    playerChoice = "Scissors";
                    break;
                case "lizard":
                    Console.WriteLine("Player: Lizard");
                    playerChoice = "Lizard";
                    break;
                case "spock":
                    Console.WriteLine("Player: Spock");
                    playerChoice = "Spock";
                    break;

                default:
                    Console.WriteLine("Invalid Entry.  Enter: Rock, Paper, Scissors, Lizard, or Spock.");
                    string scoldPlayer = Console.ReadLine();
                    playerSign();
                    break;

            }
            return playerChoice;
        }
        public void GetPlayerChoice()
        {

        }
    }
}
