using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.DataTypes
{
    internal class swaptwonumber
    {
        public void swap(int x , int y)
        {
            Console.WriteLine("Value x:" + x + " Value y : " + y);
            int temp = x;
             x = y;
             y = temp;

            Console.WriteLine("Value x:" + x + " Value y : " + y);
        }
    }
}
