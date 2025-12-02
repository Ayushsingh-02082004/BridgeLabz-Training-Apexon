using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.DataType
{
    internal class Datatypes
    {
        
        public void data()
        {
            byte b = 110;
            short sh = 1100;
            int i = 11100000;
            long l = 1100020;

            float f = 3.25f;
            double d = 13.2333;
            decimal dec = 16.98m;

            char ch = 'A';
            string s = "Ayush";

            Console.WriteLine("Byte: " + b);
            Console.WriteLine("Short: " + sh);
            Console.WriteLine("int: " + i);
            Console.WriteLine("long: " + l);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("char: " + ch);
            Console.WriteLine("stirng: " + s);
            
        }
    }
}
