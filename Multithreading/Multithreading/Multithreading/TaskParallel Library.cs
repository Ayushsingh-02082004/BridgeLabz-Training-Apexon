using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class TaskParalleLibrary
    {

        //Task

        //Represents an asynchronous unit of work
        //Can run on a separate thread
        //Can return a result
        //Task task = Task.Run(() => DoWork());

        //Two tasks , Multiple threads  , Managed Automatically


        //static void Main()
        //{
        //    Task t1 = Task.Run(() => Print("Task 1"));
        //    Task t2 = Task.Run(() => Print("Task 2"));

        //    Task.WaitAll(t1, t2);

        //    Console.WriteLine("All tasks completed");
        //}

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
