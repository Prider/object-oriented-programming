using System;

namespace stopWatch
{
 public class StopWatch
 {
   public DateTime _startTime;
   public DateTime _endTime;
   public bool _running = false;
   public void Start()
   {
     if(_running){
        throw new InvalidOperationException("Stopwatch is already running");
     }
    _startTime = DateTime.Now;
    _running = true;
  }
   public void End()
   {
    if(!_running){
      throw new InvalidOperationException("Stopwatch is not running");
    }

    _endTime = DateTime.Now;
    _running = false;
   }
   public String GetTimeSpan()
   {
    return (_endTime - _startTime).ToString();
   }
 }

}