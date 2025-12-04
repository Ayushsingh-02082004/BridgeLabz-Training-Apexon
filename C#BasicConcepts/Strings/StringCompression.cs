using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class StringCompression
    {
        public void compress(String str)
        {
            Console.Write("INitial STring is : ");
            Console.WriteLine(str);
            StringBuilder sb = new StringBuilder();
            int count = 1; // Start with 1

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    sb.Append(str[i - 1]);
                    sb.Append(count);
                    count = 1;
                }
            }

            // Append last character
            sb.Append(str[str.Length - 1]);
            sb.Append(count);

            Console.WriteLine("String After Compression is : ");
            Console.WriteLine(sb.ToString());
        }
    }
}
