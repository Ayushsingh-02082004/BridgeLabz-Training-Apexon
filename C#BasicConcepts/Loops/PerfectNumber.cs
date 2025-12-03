using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Loops
{
    internal class PerfectNumber
    {
        public void perfectnum(int num)
        {
            int sum = 0;
            for(int i = 1; i <= num / 2; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a perfect number");
            }
            else Console.WriteLine(num + " is not a perfect number");
        }
    }
}
