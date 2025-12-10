using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace oops.Constructor
{
    internal class PrivateConstructor
    {

        //When class contain private constructor private we can not make object of class outside of class.
        // using private constructor in c# we can design singleton design pattern
        private PrivateConstructor()
        {
            Console.WriteLine("This is a private constructor");
        }

        //static void Main(string[] args)
        //{
        //    PrivateConstructor p = new PrivateConstructor();
        //    Console.WriteLine("Main methord");
        //}
    }
}
