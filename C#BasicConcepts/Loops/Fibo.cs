using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Loops
{
    internal class Fibo
    {
        public void fibonacci(int num)
        {
            int a = 0, b = 1, c;

            Console.WriteLine(a + " " + b + " ");
            for(int i = 2; i<num; i++)
            {
                c = a + b;
                Console.WriteLine(c + "");
                a = b;
                b = c;

            }
        }
    }
}
