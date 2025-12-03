using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class libraryBookOverdue
    {
        public void bookoverdue(int days)
        {
            int fine = 0;
            if(days <= 7)
            {
                Console.WriteLine("Your fine is $0");
                return;
            }
            else
            {
                double finedays = days - 7;
                finedays *= 0.5;
                Console.WriteLine("your fine is : $" + finedays);
            }
        }
    }
}
