using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
  public class ChangeStateEventArgs : EventArgs
  {
    private string newState;

    public string NewState
    {
      get => newState;
      set => newState = value; 
    }

    public ChangeStateEventArgs(string s)
    {
      NewState = s;
    }
  }
}
