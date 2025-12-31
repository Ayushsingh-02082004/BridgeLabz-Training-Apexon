using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegate
{
    internal class BuiltInEventHandlerDelegate
    {
    }

    //TaskCompleted is raised by TaskManager. The handler method Manager_TaskCompleted executes when the event fires.
    public class TaskManager
    {

        //Recomended approach  - at place of the delegate event handler is used.
        public event EventHandler TaskCompleted; // Event using built-in delegate

        public void RunTask()
        {
            Console.WriteLine("Task Running...");
            OnTaskCompleted();
        }

        protected virtual void OnTaskCompleted()
        {
            TaskCompleted?.Invoke(this, EventArgs.Empty); // Raise event
        }
    }

    class Program
    {
        static void Main()
        {
            TaskManager manager = new TaskManager();
            manager.TaskCompleted += Manager_TaskCompleted; // Subscribe
            manager.RunTask();
        }

        static void Manager_TaskCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Task Completed Event Fired!");
        }
    }
}
