using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class LongestPalendromicSubstring
    {
        public Boolean solve(int i , int j , String str)
        {
            if (i >= j) return true;
            if (str[i] == str[j])
            {
                return solve(i + 1, j - 1, str);
            }
            else return false;
        }
        public void LongestPstr(String str)
        {
            Console.WriteLine("Original String is " + str);
            int maxlen = 0;
            int stpoint = 0;

            for(int i = 0; i < str.Length; i++)
            {
                for(int j = i;j<str.Length;j++)
                {
                    if(solve(i, j, str))
                    {
                        if(j-i+1 > maxlen)
                        {
                            maxlen = j-i+1;
                            stpoint = i;
                        }
                    }
                }
            }
            String s = str.Substring(stpoint, maxlen);
            Console.WriteLine("Longest Palendromic Substring is " + s);
        }
    }
}
