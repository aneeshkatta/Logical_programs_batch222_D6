using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class StopwatchSimulate
    {
        public void StopwatchMethod()
        {
            Console.WriteLine("-------------StopWatch-------------");
            var stopwatch = new Stopwatch();
            Console.WriteLine("press enter to start");
            Console.ReadLine();
            stopwatch.Start();
            Console.WriteLine("press enter to stop");
            Console.ReadLine();
            stopwatch.Stop();
            var timeelasped = stopwatch.Elapsed;
            Console.WriteLine("Time Elapsed:" + timeelasped);

        }
    }
}
