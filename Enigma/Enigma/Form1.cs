using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
  public partial class MainForm : Form
  {
    private Machine machine;

    public MainForm()
    {
      InitializeComponent();
    }

    private void btnSetRotors_Click(object sender, EventArgs e)
    {
      machine = new Machine(
        (int) updLeftRotor.Value,
        tbLeftLetter.Text[0],
        (int) updCenterRotor.Value,
        tbCenterLetter.Text[0],
        (int) updRight.Value,
        tbRightLetter.Text[0]);
      Properties.Settings.Default.ButtonState = true;
      //btnSetRotors.Enabled = false;
    }

    private void btnEncrypt_Click(object sender, EventArgs e)
    {
      tbOutput.Clear();
      char[] characters = tbInput.Text.ToCharArray();
      foreach (char character in characters)
      {
        EncryptCharacter(character - 65);
      }
    }

    private void KeyBordKeys_Click(object sender, EventArgs e)
    {
      Button clickedKey = (Button) sender;
      tbInput.Text += clickedKey.Text;
      EncryptCharacter(clickedKey.Text[0] - 65);
    }

    private void ShiftRotors()
    {
      machine.ShiftRotors();
      tbLeftLetter.Text = machine.LeftRotor.RotorLetters[machine.LeftRotor.CurrentPosition].LeftSideLetter.ToString();
      tbCenterLetter.Text =
        machine.CenterRotor.RotorLetters[machine.CenterRotor.CurrentPosition].LeftSideLetter.ToString();
      tbRightLetter.Text = machine.RightRotor.RotorLetters[machine.RightRotor.CurrentPosition].LeftSideLetter.ToString();
      rbCenterMustRotate.Checked = machine.RightRotor.ShouldRotate;
      rbLeftMustRotate.Checked = machine.CenterRotor.ShouldRotate;
    }

    private void EncryptCharacter(int character)
    {
      if (character >= 0 && character < 26)
      {
        ShiftRotors();
        tbOutput.Text += machine.Encode(character);
      }
      else if (character == -33)
      {
        tbOutput.Text += " ";
      }
    }

    private void btnSpace_Click(object sender, EventArgs e)
    {
      tbInput.Text += " ";
      tbOutput.Text += " ";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      tbInput.Clear();
      tbOutput.Clear();
    }

    private void rotor_ValueChanged(object sender, EventArgs e)
    {
      btnSetRotors.Enabled = true;
      Properties.Settings.Default.ButtonState = false;
    }
  }
}
