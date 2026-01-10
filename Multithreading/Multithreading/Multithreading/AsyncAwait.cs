using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

class AsyncAwait
{
    //Await can only be used inside an aync method 

    /*
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start");
        await Task.Delay(2000);   //non - blocking await
        Console.WriteLine("End");
    }
    */

    static async Task RunAsync()
    {
        Console.WriteLine($"Main started on Thread {Thread.CurrentThread.ManagedThreadId}");

        Task<int> task = Task.Run(() => DoCalculation());

        Console.WriteLine("Main thread is free to do other work...");

        int result = await task;   // async wait (no blocking)

        Console.WriteLine($"Result received: {result}");
        Console.WriteLine($"Main ended on Thread {Thread.CurrentThread.ManagedThreadId}");
    }

    static int DoCalculation()
    {
        Console.WriteLine($"Worker running on Thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(3000); // heavy work
        return 10 + 20;
    }

    //static void Main(string[] args)
    //{
    //    RunAsync().GetAwaiter().GetResult();

    //    // it synchronously waits for async methord to finish and returns
    //    // its reslut(or throws it exception);
    //}
}
