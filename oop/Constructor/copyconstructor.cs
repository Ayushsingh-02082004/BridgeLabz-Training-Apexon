using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Constructor
{
    internal class copyconstructor
    {

        //copy constructor is a constructor which takes object of another constructor as a parameter;
        //when we have to create multiple instances with the same value then we use the copy constructor;
        int x;
        public copyconstructor(int i)
        {
            x = i;
        }
        public copyconstructor(copyconstructor obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine($"Value of {x}");
        }
    }

}
