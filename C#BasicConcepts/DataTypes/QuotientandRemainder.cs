using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.DataTypes
{
    internal class QuotientandRemainder
    {
        public void QandR(int x , int y)
        {
            int quotient = x/y;
            int remainder = x%y;

            Console.WriteLine(quotient + " " + remainder);

        }
    }
}
