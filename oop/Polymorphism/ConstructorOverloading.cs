using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Polymorphism
{
    class constructorOverloading
    {
        int x, y, z;

        public constructorOverloading(int x)
        {
            Console.WriteLine("Constructor is called");
            this.x = 10;
        }

        public constructorOverloading(int x , int y)
        {
            Console.WriteLine("Constructor 2 is called");
            this.x = x;
            this.y = y;
        }

        public constructorOverloading(int x , int y , int z)
        {
            Console.WriteLine("Constructor 3 is called");
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Display()
        {
            Console.WriteLine($"X = {x} , Y = {y} , Z = {z}");
        }
    }

    //class Test
    //{
    //    public static void Main(string[] args)
    //    {
    //        constructorOverloading obj1 = new constructorOverloading(10);
    //        obj1.Display();
    //        constructorOverloading obj2 = new constructorOverloading(10, 20);
    //        obj2.Display();
    //        constructorOverloading obj3 = new constructorOverloading(10, 20, 30);
    //        obj3.Display();
    //        Console.ReadKey();
    //    }
    //}
}
