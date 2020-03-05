using System.Windows.Forms;

namespace StateMachine.States
{
  public interface IState
  {
    void DisconnectClicked(Machine machine);

    void StopClicked(Machine machine);

    void StandbyClicked(Machine machine);

    void MeasureClicked(Machine machine);

    void EnterState(Machine machine);

    void SetError(Machine machine);

    void ClearError(Machine machine);
  }
}