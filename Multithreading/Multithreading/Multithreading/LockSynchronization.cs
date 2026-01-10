using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Threading;

namespace LockDemo
{
    class LockExample1
    {
        // Creating a normal Method to Display Names
        public void Display()
        {
            // Lock is used to lock in the Current Thread so that another thread executes only when one is completed.
            lock (this)
            {
                for (int i = 0; i <= 3; i++)
                {
                    Thread.Sleep(1500);
                    Console.WriteLine($"My Name is Abhishek{i}");
                }
            }
        }
    }

    class Example2
    {
        //public static void Main(string[] args)
        //{
        //    // Creating object for LockExample1 Class as _locker so that we can access its Display Method
        //    LockExample1 _locker = new LockExample1();
        //    Console.WriteLine("Threading with the help of Lock");
        //    // Calling the Display Method using ThreadStart Delegate which is supplied to Thread constructor.
        //    Thread t1 = new Thread(new ThreadStart(_locker.Display));
        //    Thread t2 = new Thread(new ThreadStart(_locker.Display));
        //    t1.Start(); // Starting Thread1
        //    t2.Start(); // Starting Thread2
        //}
    }
}
