using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(WorkerThread);  //creating worker thread with the help of thread class.
        t1.Start();

        //join stops the furnter execution until the thread is completed on which the join is called.

        t1.Join();//Using Join to block the current Thread.
        Console.WriteLine("Main Thread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("Main Thread Executing");
            Thread.Sleep(5000);
        }

        Thread th = Thread.CurrentThread;
        th.Name = "Main Thread";
        Console.WriteLine("Getting name of the currenty runnig thread");

        Console.WriteLine($"Current Thread Name is : {th.Name}");
        Console.WriteLine($"Current Thread Priority is: {th.Priority}");
    }

    static void WorkerThread()
    {
        Console.WriteLine(" 2. Worker Thread Started");

        for(int i= 0; i <= 3; i++)
        {
            Console.WriteLine("Worker Thread Executing");
            Console.WriteLine("Child Thread Paused");

            Thread.Sleep(2000);
            Console.WriteLine("Child Thread REsumed");
        }
    }
}
