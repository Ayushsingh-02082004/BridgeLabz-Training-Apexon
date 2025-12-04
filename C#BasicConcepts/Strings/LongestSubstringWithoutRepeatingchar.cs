using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class LongestSubstringWithoutRepeatingchar
    {
        public void lgstr(String str)
        {
            Console.WriteLine(str);
            int startidx = 0;
            int maxlength = 0;
            int left = 0;

            HashSet<char> set = new HashSet<char> ();

            for(int i = 0; i < str.Length; i++)
            {
                
                while (set.Contains(str[i]))
                {
                    set.Remove(str[left]);
                    left++;
                }
                set.Add(str[i]);

                if(i - left + 1 > maxlength)
                {
                    maxlength = i - left + 1;
                    startidx = left;
                }
            }

            Console.WriteLine("Longest Substring without repeating char is : ");
            Console.WriteLine(str.Substring(startidx , maxlength));


        }
    }
}
