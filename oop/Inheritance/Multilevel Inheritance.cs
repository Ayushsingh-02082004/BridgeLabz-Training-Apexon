using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Inheritance
{

    //This is example of multi level inheritance where class which is derived from class it is also derived from another class.
    public class livingbeing
    {
        public void Alive()
        {
            Console.WriteLine("I am alive");
        }
    }

    class animal : livingbeing
    {
        public void eat()
        {
            Console.WriteLine("Animal eats");
        }
    }

    class Dog : animal
    {
        public void bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    //class Program
    //{
    //    public static void Main(String[] args)
    //    {
    //        Dog d = new Dog();
    //        d.eat();
    //        d.Alive();
    //        d.bark();
    //    }
    //}

}
