using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
  public class RotorLetter
  {
    public char LeftSideLetter { get; set; }

    public char RightSideLetter { get; set; }


    public RotorLetter(char leftSideLetter, char rightSideLetter)
    {
      this.LeftSideLetter = leftSideLetter;
      this.RightSideLetter = rightSideLetter;
    }
  }
}
