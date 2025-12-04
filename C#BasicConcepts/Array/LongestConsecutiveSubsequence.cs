using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Array
{
    internal class LongestConsecutiveSubsequence
    {
        public void Squs(int[] arr)
        {
            SortedSet<int> set = new SortedSet<int>(arr);
            int maxlength = 0;
            int start = 0;

            foreach (int num in arr)
            {
                if (!set.Contains(num - 1))
                {
                    int currentnum = num;
                    int length = 1;

                    while(set.Contains(currentnum+ 1))
                    {
                        currentnum++;
                        length++;
                    }
                    if(length > maxlength)
                    {
                        maxlength = length;
                        start = num;
                    }

                }
            }

            Console.WriteLine("Longest Consecutive Subsequence is : ");
            for (int i = start; i <= maxlength; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}
