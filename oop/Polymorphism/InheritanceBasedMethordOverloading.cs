using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Polymorphism
{

    //Inheritance based overloading.A method that is defined in the parent class can also be overloaded under its child class.
    //It is called Inheritance Based Method Overloading in C#. 
    
    class Class1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
    }
    class Class2 : Class1
    {
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class2 obj = new Class2();
    //        obj.Add(10, 20);
    //        obj.Add(10.5f, 20.7f);
    //        obj.Add("Pranaya", "Rout");
    //        Console.ReadKey();
    //    }
    //}
}
