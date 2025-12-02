using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class CoinsProblem
    {
        public void CP(int flips) {

            Console.WriteLine("Enter the number of times to flip coins");
            
            Random random = new Random();

            int head = 0;
            int tail = 0;

            for(int i = 0; i<flips; i++)
            {
                double value = random.NextDouble();
                if (value < 0.5)
                {
                    head++;
                }
                else tail++;
            }

            double headper = (head * 100) / flips;
            double tailper = (tail * 100) / flips;
            Console.WriteLine($"Heads: {head} ({headper:F2}%)");
            Console.WriteLine($"Tails: {tail} ({tailper:F2}%)");

        }
    }
}
