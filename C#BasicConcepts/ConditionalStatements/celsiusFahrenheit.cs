using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class celsiusFahrenheit
    {
        public void changetemperature( int x , int temp)
        {
            if ( x == 0)
            {
                double F = (temp * 9.0 / 5.0) + 32;
                Console.WriteLine("Celsius to Fahrenheit is : " + F);
            }
            if(x == 1)
            {
                double C = (temp - 32) *( 5.0 / 9.0);
                Console.WriteLine("Fahrenheit to Celsius is : " + C);
            }
        }
    }
}
