using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Array
{
    internal class missingnumber
    {
        public void missno(int[] arr)
        {
            int n = arr.Length;
            int mainsum = n * (n + 1) / 2;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                
            }
            if (mainsum == sum)
            {
                Console.WriteLine("There is no missing number : ");
                return;
            }
            else Console.WriteLine($" Missing number is : {mainsum - sum}");
            
            
        }
    }
}
