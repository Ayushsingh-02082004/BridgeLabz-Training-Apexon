using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Loops
{
    internal class PrimeNumber
    {
        public void primenum(int num)
        {
            if(num <= 1)
            {
                Console.WriteLine(num + " is not a Prime number");
                return;
            }
            for(int i = 2;i<Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(num + " is not a Prime number");
                    return;
                }
            }

            Console.WriteLine(num + " is  a Prime number");
        }
    }
}
