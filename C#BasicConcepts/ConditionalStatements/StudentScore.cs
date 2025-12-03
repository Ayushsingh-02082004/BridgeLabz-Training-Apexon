using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class StudentScore
    {
        public void score(int marks)
        {
            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine("Student Scored A grade.");
            }
            else if (marks >= 80 && marks <= 89)
            {
                Console.WriteLine("Student Scored B grade.");
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine("Student Scored C grade.");
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine("Student Scored D grade.");
            }
            else Console.WriteLine("Student Scored F grade.");
        }
    }
}
