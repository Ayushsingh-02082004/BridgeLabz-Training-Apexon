using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class kmpalgorithm
    {
        public bool Kmp(string str, string pattern)
        {
            Console.WriteLine("Initial String is : " + str);
            Console.WriteLine("Initial Pattern String is : " + pattern);

            int[] lps = ComputeLps(pattern);

            int i = 0, j = 0;

            while (i < str.Length)
            {
                if (j < pattern.Length && str[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }

                if (j == pattern.Length)
                {
                    Console.WriteLine("yes main string Contains Pattern String");
                    return true;
                }
                    
            }

            Console.WriteLine("No matching pattern found");
            return false;
        }

        public int[] ComputeLps(string pattern)
        {
            int[] lps = new int[pattern.Length];
            int len = 0, i = 1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                        len = lps[len - 1];
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }
            return lps;
        }
    }
}
