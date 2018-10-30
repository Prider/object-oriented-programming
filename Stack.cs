using System;
using System.Collections.Generic;

namespace stack{
  public class Stack
  {
    private List<Object> _list = new List<Object>();
    public void Push(Object obj){
      if(obj == null)
        throw new InvalidOperationException("no object found");
      _list.Add(obj);
    }

    public Object Pop(){
      if(_list.Count == 0)
        throw new InvalidOperationException("not found Item");

      var lastIndex = _list.Count - 1;
      var TopReturn = _list[lastIndex];

      _list.RemoveAt(lastIndex);

      return TopReturn;
    }

    public void Clear(){
      _list.Clear();
    }
  }
}