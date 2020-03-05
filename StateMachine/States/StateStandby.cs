using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.States
{
  public class StateStandby : IState
  {
    public void ClearError(Machine machine)
    {
      
    }

    public void DisconnectClicked(Machine machine)
    {
      
    }

    public void EnterState(Machine machine)
    {
      machine.CurrentState = this;
    }

    public void MeasureClicked(Machine machine)
    {
      machine.StateMeasure.EnterState(machine);
    }

    public void SetError(Machine machine)
    {
      StateError stateError = new StateError(machine);
    }

    public void StandbyClicked(Machine machine)
    {
      
    }

    public void StopClicked(Machine machine)
    {
      machine.StateStop.EnterState(machine);
    }

    public override string ToString()
    {
      return "Standby";
    }
  }
}
