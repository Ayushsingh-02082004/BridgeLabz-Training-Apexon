using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Inheritance
{

    //this is how we implement multiple interface to overcome the problem of the multiple inheritance . in interface we can only 
    // declare the methord not implement it.
    //Interface only contain definintion not implementation.
    interface Iphone
    {
        void makecall(String number);
    }

    interface Icamera
    {
        void takesphoto()  // anyway defining it is a bad pratice.
        {
            Console.WriteLine("Taking a photo");
        }
    }

    class Smartdevice : Iphone , Icamera
    {
        public void makecall(String number)
        {
            Console.WriteLine($"Calling Number {number} ");
        }

        public void tekesphoto()
        {
            Console.WriteLine("Taking Photo");
        }
    }

    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Smartdevice device = new Smartdevice();
    //        device.makecall("9026960970");
    //        device.tekesphoto();

    //    }
    //}
}
