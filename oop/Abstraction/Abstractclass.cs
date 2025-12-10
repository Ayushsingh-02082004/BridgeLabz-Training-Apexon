using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Abstraction
{

    // non abstract class is also called concrete class contains only fully implemented methords and never contain abstract methord.
    // abstract class contain both abstract and non abstract methord(concrete methord).
    // if a child class in inheriting abstract class it should implement all the abstract methord other wise it will show compile time error.
    // without implementing all the abstract methord we can not use concrete methord of an abstract class. 
    public abstract class Absparent
    {
        public void add(int x , int y)
        {
            Console.WriteLine($"Addition of {x}  and {y} is {x + y}");
        }
        public void sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x}  and {y} is {x - y}");
        }

        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);
    }

    public class Abschild : Absparent
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x}  and {y} is {x * y}");
        }
        public override void div(int x, int y)
        {
            Console.WriteLine($"Division of {x}  and {y} is {x / y}");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Abschild child = new Abschild();
    //        child.add(12, 24);
    //        child.sub(30, 21);
    //        child.mul(24, 45);
    //        child.div(25, 50);

    //    }
    //}


}
