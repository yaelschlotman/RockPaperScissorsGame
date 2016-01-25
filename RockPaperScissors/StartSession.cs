using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StartSession
    {
        string playerName;
        public StartSession()
        {
            playerName = getPlayerName();
        }

        public string getPlayerName()
        {
            Console.WriteLine("Enter Player Name:");
            string userInput = Console.ReadLine();
            return userInput;

        }
    }
}
