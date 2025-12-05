using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.Strings
{
    internal class firstnonrepeatingchar
    {
        public void fnrc(String str)
        {

            HashSet<Char> set = new HashSet<char>();
            HashSet<Char> repeat = new HashSet<char>();

            for (int i = 0; i < str.Length; i++) { 
                if(!set.Contains(str[i]))
                {
                    set.Add(str[i]);
                }
                else repeat.Add(str[i]);   
            }

            for(int i = 0;i<str.Length; i++)
            {
                if (!repeat.Contains(str[i]))
                {
                    Console.WriteLine(str[i] + " is first non repeating Character int string " + str);
                    return;
                }
            }
            Console.WriteLine("Every character is repeating in " + str);
        }
    }
}
