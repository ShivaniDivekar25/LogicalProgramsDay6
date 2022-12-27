using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    internal class StopWatch        //Creating class
    {
        public static void stopWatch()      //Creating method
        {
            var sw = Stopwatch.StartNew();
            long ticks = sw.ElapsedTicks;
            Console.WriteLine(ticks);
        }
    }
}
