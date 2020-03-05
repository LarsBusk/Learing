using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StateMachine.States;

namespace StateMachine
{
  public partial class Form1 : Form
  {
    private Machine machine;

    public string State;


    public Form1()
    {
      InitializeComponent();
      machine = new Machine();
      machine.RaiseChangeStateEvent += Machine_RaiseChangeStateEvent;
      Disconnectedlabel.ForeColor = Color.Blue;
    }

    private void Machine_RaiseChangeStateEvent(object sender, ChangeStateEventArgs e)
    {
      SetState(e.NewState);
    }

    public void SetState(string state)
    {
      switch (state)
      {
        case "Disconnected":
          Disconnectedlabel.ForeColor = Color.Blue;
          Stoplabel.ForeColor = Color.Black;
          Standbylabel.ForeColor = Color.Black;
          Measurelabel.ForeColor = Color.Black;
          break;
        case "Stop":
          Disconnectedlabel.ForeColor = Color.Black;
          Stoplabel.ForeColor = Color.Blue;
          Standbylabel.ForeColor = Color.Black;
          Measurelabel.ForeColor = Color.Black;
          break;
        case "Standby":
          Disconnectedlabel.ForeColor = Color.Black;
          Stoplabel.ForeColor = Color.Black;
          Standbylabel.ForeColor = Color.Blue;
          Measurelabel.ForeColor = Color.Black;
          break;
        case "Measure":
          Disconnectedlabel.ForeColor = Color.Black;
          Stoplabel.ForeColor = Color.Black;
          Standbylabel.ForeColor = Color.Black;
          Measurelabel.ForeColor = Color.Blue;
          break;
        case "Error":
          Disconnectedlabel.ForeColor = Color.Red;
          Stoplabel.ForeColor = Color.Red;
          Standbylabel.ForeColor = Color.Red;
          Measurelabel.ForeColor = Color.Red;
          break;
        default:
          Disconnectedlabel.ForeColor = Color.Black;
          Stoplabel.ForeColor = Color.Black;
          Standbylabel.ForeColor = Color.Black;
          Measurelabel.ForeColor = Color.Black;
          break;
      }
    }

    private void Disconnectbutton_Click(object sender, EventArgs e)
    {
      machine.CurrentState.DisconnectClicked(this.machine);
    }

    private void Stopbutton_Click(object sender, EventArgs e)
    {
      machine.CurrentState.StopClicked(machine);
    }

    private void Standbybutton_Click(object sender, EventArgs e)
    {
      machine.CurrentState.StandbyClicked(machine);
    }

    private void Measurebutton_Click(object sender, EventArgs e)
    {
      machine.CurrentState.MeasureClicked(machine);
    }

    private void SetErrorbutton_Click(object sender, EventArgs e)
    {
      machine.CurrentState.SetError(machine);
    }

    private void ClearErrorbutton_Click(object sender, EventArgs e)
    {
      machine.CurrentState.ClearError(machine);
    }
  }
}
