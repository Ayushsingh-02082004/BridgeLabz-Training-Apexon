using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace C_BasicConcepts.DataTypes
{
    public class myStopWatch
    {
        public void stwatch()
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Press ENTER to start the stopwatch");
            Console.ReadLine();
            sw.Start();

            Console.WriteLine("StopWatch Started press ENTER to stop ");
            Console.ReadLine();
            sw.Stop();

            Console.WriteLine("Elspased time is : " + sw.Elapsed.TotalSeconds + " Seconds");
        }
    }
}
