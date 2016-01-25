using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSession startSession = new StartSession();
            ComputerThrow handThrow = new ComputerThrow();
           //PlayerThrow playerThrow = new PlayerThrow();

            startSession.getPlayerName();
            handThrow.computerSign();

            Console.ReadLine();   

        }
    }
}
