using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Array
{
    internal class pairwithagivensum
    {
        public void pairs(int[] arr , int target)
        {
            HashSet<int> set = new HashSet<int>();
            
            for(int i = 0; i < arr.Length; i++)
            {
                int rem = target - arr[i];
                if (set.Contains(rem))
                {
                    Console.WriteLine(rem +"," + arr[i] + " is the pair sum");
                }
                else
                {
                    set.Add(arr[i]);
                }
            }
        }
    }
}
