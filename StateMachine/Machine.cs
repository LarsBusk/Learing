using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachine.States;

namespace StateMachine
{
  public class Machine
  {
    private static IState currentState;

    public IState CurrentState
    {
      get => currentState;

      set
      {
        currentState = value; 
        OnRaiseChangeStateEvent(new ChangeStateEventArgs(currentState.ToString()));
      }
    }

    public StateDisconnected StateDisconnected = new StateDisconnected();
    public StateStop StateStop = new StateStop();
    public StateStandby StateStandby = new StateStandby();
    public StateMeasure StateMeasure = new StateMeasure();

    public event EventHandler<ChangeStateEventArgs> RaiseChangeStateEvent;

    protected virtual void OnRaiseChangeStateEvent(ChangeStateEventArgs e)
    {
      EventHandler<ChangeStateEventArgs> handler = RaiseChangeStateEvent;

      if (handler != null)
      {
        e.NewState = CurrentState.ToString();

        handler(this, e);
      }
    }

    public Machine()
    {
      StateDisconnected.EnterState(this);
    }
  }
}
