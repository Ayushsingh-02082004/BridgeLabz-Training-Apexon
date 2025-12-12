using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Inheritance
{

    // if methord did not use virtual keyword then we can not override it . 
   
    public class parent
    {
        public virtual void show()
        {
            Console.WriteLine("Parent class show methord : ");
        }
        public void Display()
        {
            Console.WriteLine("Parent class Display methord : ");
        }
    }

    public class Child : parent
    {
        public override void show()                 // overriding using inheritance 
        {
            Console.WriteLine("Child class show methord");
        }

        public new void display()
        {
            Console.WriteLine("Child class Display methord"); // methord hiding using new keyword.
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Child obj = new Child();
    //        obj.show();
    //        obj.Display();
    //        Console.ReadKey();
    //    }
    //}

}
