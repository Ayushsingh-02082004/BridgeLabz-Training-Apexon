using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class leapyear
    {
        public void ly(int year)
        {
            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
                Console.WriteLine("Leap Year");
            }
            else {
                Console.WriteLine("Not Leap Year");
            }
        }
    }
}
