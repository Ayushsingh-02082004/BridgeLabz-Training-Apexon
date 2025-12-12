


using oop.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Inheritance
{

    //For overriding from the virtual class we have to delcare the methord with virtual keyword.
    // without virtual keyword methord can not be overridden in its child class.
    //Simple explanation:
    //The compiler sees that obj is of type Parent.
    //But at runtime, obj actually refers to a Child object.
    //So the Child’s version of Show() is executed.
    //That’s why it’s called Dynamic or Runtime Polymorphism — the decision is made while running the program, not while compiling it.
    class Class1
    {
        //Virtual Function (Overridable Method)
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class1 obj1 = new Class2();
    //        obj1.Show();
    //        Class2 obj2 = new Class2();
    //        obj2.Show();
    //        Console.ReadKey();
    //    }
    //}
}
