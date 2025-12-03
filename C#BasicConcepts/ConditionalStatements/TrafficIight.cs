using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class TrafficIight
    {
        public void light(int sec)
        {
            int red = sec;
            int green = sec;
            int yellow = sec;
            while (red > 0)
            {
                red--;
                Console.WriteLine($"Stop for {red} seconds");
            }
            while (green > 0)
            {
                green--;
                Console.WriteLine($"Go for {green} seconds");
            }
            while (yellow > 0)
            {
                yellow--;
                Console.WriteLine($"Ready to go in  {yellow} seconds");
            }
        }
    }
}
