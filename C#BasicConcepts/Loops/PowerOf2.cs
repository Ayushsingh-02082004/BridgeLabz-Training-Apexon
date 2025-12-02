using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Loops
{
    internal class PowerOf2
    {
        public void power2(int x)
        {
            if(x < 31)
            {
                for (int i = 1; i <= x-1; i++)
                {
                    Console.WriteLine(Math.Pow(2 , i));
                }
            }
            else
            {
                Console.WriteLine("Give input only less than 31");
            }
        }
    }
}
