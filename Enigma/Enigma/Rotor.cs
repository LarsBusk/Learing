using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
  internal class Rotor
  {
    public List<RotorLetter> RotorLetters { get; set; }

    public int ArrowPosition { get; set; }

    public int CurrentPosition { get; set; }

    public Rotor()
    {
      this.RotorLetters = new List<RotorLetter>();
    }

    public bool ShouldRotate
    {
      get { return CurrentPosition == ArrowPosition; }
    }

    public void Rotate()
    {
      CurrentPosition ++;
      CurrentPosition = AdjustPosition(CurrentPosition);
    }

    public int Encode(int inputPosition, bool rightToLeft)
    {
      int letterPosition = CurrentPosition + inputPosition;
      letterPosition = AdjustPosition(letterPosition);
      int returnLetter;

      if (rightToLeft)
      {
        returnLetter = RotorLetters.FindIndex(l => l.LeftSideLetter.Equals(RotorLetters[letterPosition].RightSideLetter)) - CurrentPosition;
      }
      else
      {
        returnLetter = RotorLetters.FindIndex(l => l.RightSideLetter.Equals(RotorLetters[letterPosition].LeftSideLetter)) - CurrentPosition;
      }

      returnLetter = AdjustPosition(returnLetter);
      return returnLetter;
    }

    private static int AdjustPosition(int position)
    {
      position = position > 25 ? position -= 26 : position;
      position = position < 0 ? position += 26 : position;
      return position;
    }
  }
}
