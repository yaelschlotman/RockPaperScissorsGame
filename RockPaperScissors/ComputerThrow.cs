using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace RockPaperScissors 
{
    class ComputerThrow  
    {
        string computerChoice;
        string[] items = { "Rock", "Paper", "Scissors, Lizard, Spock" };
        public string computerSign()
        {
            Random item = new Random();  
            int n = item.Next(0, 4); 
            computerChoice = items[n]; 
            return computerChoice;
        }
      
                
    }
}
