using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Loops
{
    internal class harmonicnumber
    {
        public void hrno(int n)
        {
            Double ans = 0;
            
            for(int i = 1; i <= n; i++)
            {
                Double temp = (double)1 / i;
                ans += temp;
            }

            Console.WriteLine(ans);
        }
    }
}
