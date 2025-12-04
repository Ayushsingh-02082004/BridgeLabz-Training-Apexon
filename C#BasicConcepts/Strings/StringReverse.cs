using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class StringReverse
    {
        public void rev(String Str)
        {

            StringBuilder sb = new StringBuilder();
            int k = 0;
            for(int i = Str.Length-1; i>=0;i--)
            {
                sb.Append(Str[i]);

            }
            Console.WriteLine("String After Reversal is : ");
            Console.WriteLine(sb.ToString());
        }
    }
}
