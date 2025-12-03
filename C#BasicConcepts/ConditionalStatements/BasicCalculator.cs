using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class BasicCalculator
    {
        public void calcuator(int x , int y , char ch)
        {
            if(ch == 'a' || ch == 'A')
            {
                Console.WriteLine("Addition of A and B is : " + (x + y));
            }
            else if (ch == 's' || ch == 'S')
            {
                Console.WriteLine("Subtraction of A and B is : " + (x - y));
            }
            else if (ch == 'm' || ch == 'M')
            {
                Console.WriteLine("Multiplication of A and B is : " + (x * y));
            }
            else if (ch == 'd' || ch == 'D')
            {
                Console.WriteLine("Division of A and B is : " + (x / y));
            }
            else
            {
                Console.WriteLine("Provide valid Input");
            }
        }
    }
}
