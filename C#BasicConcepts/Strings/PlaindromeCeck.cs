using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class PlaindromeCeck
    {
        public void plc(String str)
        {
            int k = str.Length - 1;
            Console.WriteLine(str);
            for(int i = 0;i<str.Length/2; i++)
            {
                if (str[i] != str[k--])
                {
                    Console.WriteLine("Not a Palindrome String");
                    return;
                }
            }

            Console.WriteLine("It is a plaindrome String");
        }

    }
}
