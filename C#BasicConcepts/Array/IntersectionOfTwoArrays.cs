using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Array
{
    internal class IntersectionOfTwoArrays
    {
        public void Intersection(int[] arr , int[] arr2)
        {
            Dictionary<int,int> map = new Dictionary<int, int> (); 

            foreach (int num in arr)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else map[num] = 1;
            }

            Console.WriteLine("Intersection : ");
            foreach (int num in arr2)
            {
                if(map.ContainsKey(num) && map[num] > 0)
                {
                    Console.Write(num + " ");
                    map[num]--;
                }
            }

        }
    }
}
