using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class RockPaperCissor
    {
        public void rpc(String str)
        {
            Random rand = new Random();
            int com = rand.Next(1, 4);
            String computer = "";

            if(com == 1)
            {
                computer = "rock";
            }
            else if (com == 2)
            {
                computer = "paper";
            }
            else if (com == 3)
            {
                computer = "cissor";
            }

            if ((com == 1 && str == "paper") || (com == 2 && str == "cissor") || (com == 3 && str == "rock"))
            {
                Console.WriteLine("User Wins");
            }
            else if ((com == 1 && str == "rock") || (com == 2 && str == "paper") || (com == 3 && str == "cissor"))
            {
                Console.WriteLine("Draw");
            }
            else Console.WriteLine("Computer Wins");
        }
    }
}
