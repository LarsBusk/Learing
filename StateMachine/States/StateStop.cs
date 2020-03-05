using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.States
{
  public class StateStop : IState
  {
    public void ClearError(Machine machine)
    {
      
    }

    public void DisconnectClicked(Machine machine)
    {
      machine.StateDisconnected.EnterState(machine);
    }

    public void EnterState(Machine machine)
    {
      machine.CurrentState = this;
    }

    public void MeasureClicked(Machine machine)
    {
      
    }

    public void SetError(Machine machine)
    {
      StateError stateError = new StateError(machine);
    }

    public void StandbyClicked(Machine machine)
    {
      machine.StateStandby.EnterState(machine);
    }

    public void StopClicked(Machine machine)
    {
      
    }

    public override string ToString()
    {
      return "Stop";
    }
  }
}
