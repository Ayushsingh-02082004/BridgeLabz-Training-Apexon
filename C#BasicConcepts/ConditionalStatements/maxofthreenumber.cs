using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class maxofthreenumber
    {
        public void mthree(int x , int y , int z)
        {
            int greatest = Math.Max(x, Math.Max(y, z));
            Console.WriteLine(greatest + " is the Greatest number");

        }
    }
}
