using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class Anagramcheck
    {
        public void ana(String str, String s)
        {
            Console.WriteLine("Two Strings Are : ");
            Console.WriteLine(str);
            Console.WriteLine(s);
            if (str.Length != s.Length)
            {
                Console.WriteLine("Not Anagram Strings");
                return;
            }
            for (int i = 0; i< str.Length-1; i++)
            {
                if(!s.Contains(str[i]))
                {
                    Console.WriteLine("Not Anagram Strings");
                    return;
                }
            }
            Console.WriteLine("String are anagram");

        }
    }
}
