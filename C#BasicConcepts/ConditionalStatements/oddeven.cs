using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class oddeven
    {
        public void oe(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine(num + " is even number");
            }
            else Console.WriteLine(num + " is odd number");
        }
    }
}
