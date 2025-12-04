using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Array
{
    internal class RotatearrayBykPoints
    {

        public void reverse(int[] arr , int k)
        {
            Console.WriteLine("Array Before Rotation : ");
            foreach (int i in arr) Console.Write(i + " ");
            System.Array.Reverse(arr);
            System.Array.Reverse(arr, 0, k);
            System.Array.Reverse(arr, k, arr.Length-k);
            Console.WriteLine($"Array After Rotation of {k} points : ");
            foreach (int i in arr) Console.Write(i + " ");
        }
    }
}
