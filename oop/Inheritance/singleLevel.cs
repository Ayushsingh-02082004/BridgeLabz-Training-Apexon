using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Inheritance
{

    //This is single level inheritance in which derived class is inherited by one base class
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Animal Eats : ");
        }
    }
    class dog : Animal 
    { 
        public void bark()
        {
            Console.WriteLine("Dog barks :");
        }
    }

    //class Program
    //{
    //    public static void Main(String [] args)
    //    {
    //        dog d = new dog();
    //        d.eat();
    //        d.bark();
    //    }
    //}
}
