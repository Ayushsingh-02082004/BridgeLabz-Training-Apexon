using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Loops
{
    internal class Reverse
    {
        public void reversenum(int num)
        {
            int rev = 0;

            while(num > 0)
            {
                int no = num % 10;
                rev = rev * 10 + no;
                num = num / 10;
            }

            Console.WriteLine(rev);
        }
    }
}
