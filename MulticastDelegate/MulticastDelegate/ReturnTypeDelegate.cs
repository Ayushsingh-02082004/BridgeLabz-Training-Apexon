using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegate
{

    //Multicast Delegate with return type and it returns the value of only last executed methrod when invoked.

    // Deletegate's return type is int
    //public delegate int SampleDelegate();
    //public class Program
    //{
    //    static void Main()
    //    {
    //        SampleDelegate del = new SampleDelegate(MethodOne);
    //        del += MethodTwo;

    //        // The Value Returned By Delegate will be 2, returned by the MethodTwo(),
    //        // as it is the last method in the invocation list.
    //        int ValueReturnedByDelegate = del();
    //        Console.WriteLine($"Returned Value = {ValueReturnedByDelegate}");
    //        Console.ReadKey();
    //    }
    //    // This method returns one
    //    public static int MethodOne()
    //    {
    //        Console.WriteLine("MethodOne is Executed");
    //        return 1;
    //    }
    //    // This method returns two
    //    public static int MethodTwo()
    //    {
    //        Console.WriteLine("MethodTwo is Executed");
    //        return 2;
    //    }
    //}
}
