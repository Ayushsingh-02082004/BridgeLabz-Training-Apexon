using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oops.Constructor
{
    internal class staticConstructor
    {

        // in c# we can define any number of constructor but each constructor must have different signature
        // so in class we can define one no argument constructor and plus n number of parameterized constructor.

        static staticConstructor()
        {
            // In static constructor we can not use any access modifier 
            //if a class contain any static variable then only static constructors are used
            //Static constructors are used for initializing static variables and are never called explictly .
            // implicitly means automatic done by compiler and explicit means we are doing that.
            // There can be only one static constructor in a class.
            // static date members can be initialized in non static constructors but in static constructor only static data members are initialized;

            Console.WriteLine("Static constructor executed implicitly ");

        }


    }
}
