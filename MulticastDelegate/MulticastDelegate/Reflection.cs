using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MulticastDelegate
{
    internal class Reflection
    {

        ///we load the type t as a string using the typeof method.Then we apply reflection on t to find any information about string class, like its name, fullname, namespace, and basetype
        static void Main(string[] args)
        {
            Type t = typeof(string);

            //Use Reflection to find about any sort of data related to t;
            Console.WriteLine("Name :{0}", t.Name);
            Console.WriteLine("FullName :{0}", t.FullName);
            Console.WriteLine("Name space :{0}", t.Namespace);
            Console.WriteLine("BaseType : {0}", t.BaseType);
        }
    }
}
