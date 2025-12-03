using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Array
{
    internal class MoveZeroesEnd
    {
        public  void totheend(int[] arr) {
            int[] newarr = new int[arr.Length];
            int k = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newarr[k++] = arr[i];
                }
            }
            Console.WriteLine("New Array After Removing Zero is : ");
            foreach(int i in newarr)
            {
                Console.Write(i);
            }
        }
    }
}
