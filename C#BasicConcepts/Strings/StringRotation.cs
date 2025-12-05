using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class StringRotation
    {
        public void rotate(String str  ,string s2)
        {
            Console.WriteLine("Initial strings are : ");
            Console.WriteLine(str);
            Console.WriteLine(s2);
            if(str.Length != s2.Length)
            {
                Console.WriteLine("STring 1 is not Rotation of STring 2");
                return;
            }
            str = str + str;
            if (str.Contains(s2))
            {
                Console.WriteLine("STring 1 is Rotation of STring 2");
                return;
            }

            Console.WriteLine("STring 1 is not Rotation of STring 2");
        }

    }
}
