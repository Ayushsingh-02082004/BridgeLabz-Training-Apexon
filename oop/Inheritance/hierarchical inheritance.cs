using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Inheritance
{

    //IN hierarchical inheritance multible sub class are derived from the single base class .
    class Animals
    {
        public void eat()
        {
            Console.WriteLine("Animal eats");
        }
    }

    class Dogs : Animals
    {
        public void bark()
        {
            Console.WriteLine("Dogs Barks");
        }
    }

    class Cats : Animals
    {
        public void meow()
        {
            Console.WriteLine("Cats make sound meow");
        }
    }

    //class Program
    //{

    //    public static void Main(string[] args)
    //    {
    //        Dogs dog = new Dogs();
    //        Cats cat = new Cats();

    //        dog.bark();
    //        dog.eat();

    //        cat.meow();
    //        cat.eat();

    //    }

    //}
}
