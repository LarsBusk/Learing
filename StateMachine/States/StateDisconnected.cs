using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateMachine.States
{
  public class StateDisconnected : IState
  {
    public void ClearError(Machine machine)
    {
      
    }

    public void DisconnectClicked(Machine machine)
    {
      machine.CurrentState = machine.StateStop;
    }

    public void EnterState(Machine machine)
    {
      machine.CurrentState = this;
    }

    public  void MeasureClicked(Machine machine)
    {
      
    }

    public void SetError(Machine machine)
    {
      
    }

    public void StandbyClicked(Machine machine)
    {
      
    }

    public  void StopClicked(Machine machine)
    {
      machine.StateStop.EnterState(machine);
    }

    public override string ToString()
    {
      return "Disconnected";
    }
  }
}
