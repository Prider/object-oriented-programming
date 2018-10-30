using System.Collections.Generic;
using System;

namespace workFlowEngine
{
  public interface ITask{
      void Execute();
  }

  public class Video : ITask
  {
    public void Execute(){
      Console.WriteLine(" video task");
    }
  }  

  public class Email : ITask
    {
    public void Execute(){
      Console.WriteLine(" Email task");
    }
  }  


public class WorkFlowEngine
 {
   private List<ITask> T = new List<ITask>();

   public void Add(ITask task)
   {
     T.Add(task);
   }

   public void remove(ITask task)
   {
     T.Remove(task);
   }

   public void Run() {
     foreach(ITask t in  T)
     {
       t.Execute();
     }
   }
 }
}