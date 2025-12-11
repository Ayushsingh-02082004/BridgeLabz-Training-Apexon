using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Polymorphism
{
    //In C#, the Operator functions are the same as normal functions. The only difference is, that the name of an operator function
    //is always the operator keyword followed by the symbol of the operator, and operator functions are called when the
    //corresponding operator is used.
    public class Complex
    {
        private int real;
        private int img;
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }

        public static Complex operator +(Complex c1, Complex c2)  // overloaded + operator. at place of add methord we can use + operator.
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }

        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Complex c1 = new Complex(3, 7);
    //        c1.Display();
    //        Complex c2 = new Complex(5, 2);
    //        c2.Display();
    //        Complex c3 = c1 + c2;
    //        c3.Display();
    //        Console.ReadKey();
    //    }
    //}
}
