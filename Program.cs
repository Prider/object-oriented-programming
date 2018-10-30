using System;
using System.Threading;

using stopWatch;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
          var stopwatch = new StopWatch();
          stopwatch.Start();
          for(var i =0; i < 2; i++){
            Thread.Sleep(1);
          }
          stopwatch.End();
          Console.WriteLine("TimeSapn : {0}", stopwatch.GetTimeSpan());
        }
    }
}
