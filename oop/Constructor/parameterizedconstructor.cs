using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Constructor
{
    internal class parameterizedconstructor
    {
        public parameterizedconstructor(int i)
        {
            //Parameterized constructor is a type of Explicit or user defined constructor in which user provide parameter in its constructor
            // and it uses that value in inside logic.

            Console.WriteLine($"This is parameterized Constructor {i}");
            
        }
    }
}
