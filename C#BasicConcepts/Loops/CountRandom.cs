using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Loops
{
    internal class CountRandom
    {
        public void CouponsNumber(int n)
        {
            HashSet<int> Collection = new HashSet<int>();
            int count = 0;

            while(Collection.Count < n)
            {
                int coupon = new Random().Next(1, n + 1);
                Collection.Add(coupon);
                count++;
            }

            Console.WriteLine(count + " times it takes to generate coupon with random number");
        }
    }
}
