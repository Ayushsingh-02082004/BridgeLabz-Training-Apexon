using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oops.Constructor
{
    internal class userdefinedDefaultConstructor
    {
        public int key;
        public String Address;
        public bool isparmanent;
        public userdefinedDefaultConstructor()
        {
            key = 23;
            Address = "Hsr layout";
            isparmanent = true;
        }

        public void Display()
        {
            Console.WriteLine($"Age is : {key}");
            Console.WriteLine($"Address is {Address}");
            Console.WriteLine("he is parmanent in company :" + isparmanent);
        }
    }
}
