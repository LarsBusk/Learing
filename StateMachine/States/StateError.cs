using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.States
{
  public class StateError : IState
  {
    private IState fromState;

    public StateError(Machine machine)
    {
      fromState = machine.CurrentState;
      machine.CurrentState = this;
    }
    public void ClearError(Machine machine)
    {
      if (fromState == machine.StateStop)
      {
        machine.StateStop.EnterState(machine);
      }
      else
      {
        machine.StateStandby.EnterState(machine);
      }
    }

    public void DisconnectClicked(Machine machine)
    {
      
    }

    public void EnterState(Machine machine)
    {
      
    }

    public void MeasureClicked(Machine machine)
    {
      
    }

    public void SetError(Machine machine)
    {
      
    }

    public void StandbyClicked(Machine machine)
    {
      
    }

    public void StopClicked(Machine machine)
    {
      
    }

    public override string ToString()
    {
      return "Error";
    }
  }
}
