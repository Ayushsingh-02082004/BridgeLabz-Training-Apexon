using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegate
{

    //Steps to Create a Custom Attribute
    //    Create a class derived from System.Attribute.
    //    Use [AttributeUsage] to specify how and where it can be applied.
    //    Define constructors and properties for initialization.

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class InfoAttribute : Attribute
    {
        public string Author { get; }
        public string Version { get; }

        public InfoAttribute(string author, string version)
        {
            Author = author;
            Version = version;
        }
    }

    [Info("Geek", "1.0")]
    public class student
    {
        [Info("Geek", "1.1")]
        public void Display()
        {
            Console.WriteLine("Student details displayed");
        }
    }
}
